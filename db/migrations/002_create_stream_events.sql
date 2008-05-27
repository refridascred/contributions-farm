-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, ratio) VALUES (97, 'strict', 39.11);
INSERT INTO stream_events (rank, owner, ratio) VALUES (75, 'edge', 50.35);
INSERT INTO stream_events (rank, owner, ratio) VALUES (91, 'legacy', 42.99);
