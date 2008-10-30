-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, count, label) VALUES ('edge', 20.49, 59, 'green');
