-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, score, level, region) VALUES (97.99, 67.33, 15, 'fallback');
INSERT INTO stream_events (ratio, score, level, region) VALUES (59.9, 33.15, 72, 'open');
INSERT INTO stream_events (ratio, score, level, region) VALUES (74.63, 93.38, 55, 'edge');
