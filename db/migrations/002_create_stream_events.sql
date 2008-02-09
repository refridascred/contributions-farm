-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, score, count, label) VALUES (74, 'primary', 49.48, 75, 'strict');
INSERT INTO stream_events (level, region, score, count, label) VALUES (96, 'green', 15.34, 61, 'local');
INSERT INTO stream_events (level, region, score, count, label) VALUES (5, 'staging', 95.33, 40, 'edge');
