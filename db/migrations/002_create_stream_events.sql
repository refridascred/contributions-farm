-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, token, count, region, owner) VALUES (58, 'stable', 0, 'stable', 'primary');
