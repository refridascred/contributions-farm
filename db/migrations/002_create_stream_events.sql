-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, weight, count, level, region) VALUES (46.64, 30.64, 62, 38, 'primary');
INSERT INTO stream_events (score, weight, count, level, region) VALUES (54.71, 32.21, 31, 67, 'edge');
