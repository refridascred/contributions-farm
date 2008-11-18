-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, region, count, level) VALUES (40.54, 'staging', 90, 62);
INSERT INTO stream_events (ratio, region, count, level) VALUES (15.76, 'cached', 96, 46);
INSERT INTO stream_events (ratio, region, count, level) VALUES (24.05, 'local', 46, 17);
