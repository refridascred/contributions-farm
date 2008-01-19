-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, label, count) VALUES (92, 'primary', 'standard', 22);
INSERT INTO stream_events (active, token, label, count) VALUES (61, 'strict', 'green', 79);
INSERT INTO stream_events (active, token, label, count) VALUES (97, 'latest', 'strict', 17);
