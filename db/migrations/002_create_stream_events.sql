-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, owner, score, rank) VALUES (14, 'legacy', 78.04, 64);
INSERT INTO stream_events (count, owner, score, rank) VALUES (93, 'legacy', 40.06, 61);
INSERT INTO stream_events (count, owner, score, rank) VALUES (68, 'strict', 2.02, 42);
