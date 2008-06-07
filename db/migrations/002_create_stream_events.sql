-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, ratio, region, count) VALUES (84.8, 16, 40.31, 'strict', 20);
INSERT INTO stream_events (score, level, ratio, region, count) VALUES (9.0, 44, 7.95, 'open', 1);
