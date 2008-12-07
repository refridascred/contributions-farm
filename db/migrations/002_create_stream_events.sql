-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, label, token, weight) VALUES (98, 'strict', 'blue', 81.17);
INSERT INTO stream_events (count, label, token, weight) VALUES (64, 'cached', 'latest', 67.16);
INSERT INTO stream_events (count, label, token, weight) VALUES (42, 'local', 'local', 13.78);
