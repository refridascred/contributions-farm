-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, level, rank, region, weight) VALUES (11.53, 7, 38, 'green', 32.12);
INSERT INTO stream_events (score, level, rank, region, weight) VALUES (11.45, 99, 16, 'legacy', 71.28);
