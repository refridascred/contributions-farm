-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, level, count, region) VALUES ('edge', 13, 51, 'legacy');
INSERT INTO stream_events (label, level, count, region) VALUES ('eu-west', 97, 34, 'edge');
INSERT INTO stream_events (label, level, count, region) VALUES ('blue', 41, 84, 'legacy');
