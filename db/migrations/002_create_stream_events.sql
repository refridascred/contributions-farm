-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region, score) VALUES (29.01, 'edge', 24.9);
INSERT INTO stream_events (weight, region, score) VALUES (50.65, 'blue', 93.13);
