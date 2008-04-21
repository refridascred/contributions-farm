-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, ratio, rank, count, score) VALUES ('fallback', 84.9, 59, 24, 27.67);
INSERT INTO stream_events (region, ratio, rank, count, score) VALUES ('open', 46.06, 7, 54, 56.31);
INSERT INTO stream_events (region, ratio, rank, count, score) VALUES ('edge', 72.36, 19, 63, 89.04);
