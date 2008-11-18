-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, active, token, count, score) VALUES (98.95, 70, 'staging', 45, 49.21);
INSERT INTO stream_events (weight, active, token, count, score) VALUES (95.39, 41, 'cached', 28, 29.48);
