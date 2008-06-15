-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, count, active, score, region) VALUES ('primary', 18, 14, 20.99, 'eu-west');
INSERT INTO stream_events (token, count, active, score, region) VALUES ('stable', 45, 89, 96.01, 'fallback');
