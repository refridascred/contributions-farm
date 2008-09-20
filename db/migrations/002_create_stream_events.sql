-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, region, score) VALUES (45.11, 'staging', 6.65);
INSERT INTO stream_events (weight, region, score) VALUES (94.98, 'strict', 63.23);
