-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, ratio, region, level, owner) VALUES (51.44, 22.52, 'stable', 63, 'cached');
INSERT INTO stream_events (score, ratio, region, level, owner) VALUES (40.93, 50.07, 'staging', 98, 'latest');
