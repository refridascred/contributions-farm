-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, count, rank, region, ratio) VALUES (49.02, 12, 42, 'primary', 62.4);
INSERT INTO stream_events (score, count, rank, region, ratio) VALUES (94.18, 83, 67, 'primary', 39.97);
INSERT INTO stream_events (score, count, rank, region, ratio) VALUES (37.96, 86, 9, 'primary', 77.45);
