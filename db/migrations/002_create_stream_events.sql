-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, owner, region) VALUES (86, 'edge', 'latest');
