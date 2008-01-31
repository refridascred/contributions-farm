-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, region, owner, rank) VALUES (93, 'cached', 'local', 32);
INSERT INTO stream_events (count, region, owner, rank) VALUES (28, 'fallback', 'open', 71);
