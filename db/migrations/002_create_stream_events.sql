-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, region, score, ratio, count) VALUES (57, 'strict', 80.08, 30.15, 16);
INSERT INTO stream_events (level, region, score, ratio, count) VALUES (76, 'standard', 98.26, 23.42, 58);
INSERT INTO stream_events (level, region, score, ratio, count) VALUES (85, 'stable', 57.51, 48.64, 2);
