-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, region, token, label) VALUES (86, 'latest', 'staging', 'cached');
INSERT INTO stream_events (level, region, token, label) VALUES (92, 'legacy', 'eu-west', 'fallback');
