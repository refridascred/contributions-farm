-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, token, region, count) VALUES (90, 'fallback', 'local', 85);
INSERT INTO stream_events (level, token, region, count) VALUES (68, 'primary', 'legacy', 5);
