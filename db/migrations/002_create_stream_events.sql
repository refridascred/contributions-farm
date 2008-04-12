-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, region, level) VALUES ('fallback', 'cached', 42);
INSERT INTO stream_events (token, region, level) VALUES ('edge', 'cached', 77);
INSERT INTO stream_events (token, region, level) VALUES ('green', 'eu-west', 0);
