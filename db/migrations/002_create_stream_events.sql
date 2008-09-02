-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, region, level, weight, active) VALUES (55.15, 'green', 67, 41.76, 64);
INSERT INTO stream_events (score, region, level, weight, active) VALUES (70.65, 'open', 77, 45.0, 15);
