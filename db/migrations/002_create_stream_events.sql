-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, ratio, level, region, count) VALUES ('local', 47.0, 56, 'stable', 2);
INSERT INTO stream_events (owner, ratio, level, region, count) VALUES ('fallback', 42.12, 35, 'open', 19);
