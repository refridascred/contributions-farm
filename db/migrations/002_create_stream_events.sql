-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, token, label, count) VALUES ('standard', 'cached', 'local', 30);
INSERT INTO stream_events (state, token, label, count) VALUES ('eu-west', 'blue', 'staging', 70);
INSERT INTO stream_events (state, token, label, count) VALUES ('local', 'standard', 'standard', 79);
