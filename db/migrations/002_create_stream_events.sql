-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, region, token, owner) VALUES (33, 'legacy', 'cached', 'fallback');
INSERT INTO stream_events (count, region, token, owner) VALUES (57, 'latest', 'stable', 'primary');
