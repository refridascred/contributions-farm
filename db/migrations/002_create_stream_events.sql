-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, count, region, level) VALUES (17.44, 16, 'local', 88);
INSERT INTO stream_events (ratio, count, region, level) VALUES (16.38, 6, 'staging', 80);
INSERT INTO stream_events (ratio, count, region, level) VALUES (96.84, 60, 'legacy', 10);
