-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, token, count, level, region) VALUES (40, 'edge', 62, 57, 'primary');
