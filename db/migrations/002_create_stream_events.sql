-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, level, region, count) VALUES ('fallback', 35, 'eu-west', 40);
