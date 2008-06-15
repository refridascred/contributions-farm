-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, count, ratio, score, level) VALUES (42.43, 87, 39.32, 72.11, 53);
INSERT INTO stream_events (weight, count, ratio, score, level) VALUES (65.9, 74, 49.25, 34.11, 90);
