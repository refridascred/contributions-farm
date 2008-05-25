-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, region, rank) VALUES (16.54, 63.45, 'legacy', 11);
INSERT INTO stream_events (ratio, score, region, rank) VALUES (71.64, 27.38, 'edge', 12);
INSERT INTO stream_events (ratio, score, region, rank) VALUES (6.87, 41.33, 'strict', 78);
