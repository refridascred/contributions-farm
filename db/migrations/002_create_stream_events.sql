-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, count, rank) VALUES (13, 'fallback', 35, 41);
INSERT INTO stream_events (active, owner, count, rank) VALUES (53, 'edge', 32, 6);
INSERT INTO stream_events (active, owner, count, rank) VALUES (22, 'standard', 9, 51);
