-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, region, count, weight, token) VALUES (34, 'legacy', 62, 28.12, 'stable');
