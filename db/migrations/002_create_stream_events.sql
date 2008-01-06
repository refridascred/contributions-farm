-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, owner, count, region) VALUES (73, 'open', 35, 'latest');
INSERT INTO stream_events (active, owner, count, region) VALUES (14, 'stable', 34, 'strict');
INSERT INTO stream_events (active, owner, count, region) VALUES (10, 'strict', 0, 'legacy');
