-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, owner, rank, count) VALUES (5, 'strict', 73, 63);
INSERT INTO stream_events (level, owner, rank, count) VALUES (54, 'legacy', 25, 70);
INSERT INTO stream_events (level, owner, rank, count) VALUES (30, 'standard', 37, 10);
