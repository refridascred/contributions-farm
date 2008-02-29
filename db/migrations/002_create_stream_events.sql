-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, rank, level, owner) VALUES ('blue', 38, 47, 'edge');
