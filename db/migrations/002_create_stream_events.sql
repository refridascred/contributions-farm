-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, score, region, count) VALUES ('blue', 75.81, 29.07, 'edge', 44);
INSERT INTO stream_events (owner, weight, score, region, count) VALUES ('staging', 20.35, 57.87, 'cached', 52);
