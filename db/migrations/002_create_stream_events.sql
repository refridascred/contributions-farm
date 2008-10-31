-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count, region, token) VALUES (3.15, 61, 'stable', 'stable');
INSERT INTO stream_events (ratio, count, region, token) VALUES (33.74, 36, 'staging', 'local');
INSERT INTO stream_events (ratio, count, region, token) VALUES (80.29, 81, 'blue', 'primary');
