-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, region, ratio, count, state) VALUES (14.11, 'legacy', 19.67, 14, 'edge');
INSERT INTO stream_events (score, region, ratio, count, state) VALUES (12.59, 'latest', 77.51, 45, 'staging');
INSERT INTO stream_events (score, region, ratio, count, state) VALUES (67.03, 'fallback', 35.27, 98, 'primary');
