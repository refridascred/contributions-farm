-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, level, region, count, score) VALUES ('stable', 68, 'edge', 83, 36.17);
INSERT INTO stream_events (owner, level, region, count, score) VALUES ('staging', 74, 'open', 29, 41.41);
