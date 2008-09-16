-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, weight, ratio) VALUES (78.7, 'blue', 46.8, 60.98);
INSERT INTO stream_events (score, region, weight, ratio) VALUES (94.84, 'stable', 66.35, 23.5);
