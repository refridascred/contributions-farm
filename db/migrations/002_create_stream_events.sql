-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, score, count, active) VALUES (62.69, 59.58, 10, 86);
INSERT INTO stream_events (weight, score, count, active) VALUES (86.02, 16.98, 80, 48);
INSERT INTO stream_events (weight, score, count, active) VALUES (86.64, 47.64, 4, 42);
