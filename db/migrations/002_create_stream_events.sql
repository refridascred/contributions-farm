-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, score, token, count) VALUES (32.73, 73.0, 'edge', 73);
INSERT INTO stream_events (ratio, score, token, count) VALUES (56.22, 88.92, 'local', 26);
INSERT INTO stream_events (ratio, score, token, count) VALUES (72.84, 19.85, 'strict', 49);
