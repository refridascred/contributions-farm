-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, label, token, active) VALUES (5.57, 'fallback', 'legacy', 89);
INSERT INTO stream_events (weight, label, token, active) VALUES (73.26, 'edge', 'latest', 60);
INSERT INTO stream_events (weight, label, token, active) VALUES (92.16, 'latest', 'primary', 98);
