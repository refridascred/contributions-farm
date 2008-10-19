-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, owner, ratio, count, weight) VALUES ('fallback', 'stable', 95.96, 52, 47.16);
INSERT INTO stream_events (region, owner, ratio, count, weight) VALUES ('green', 'strict', 81.36, 34, 62.26);
