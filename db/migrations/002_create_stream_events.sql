-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, rank, owner) VALUES (39.74, 19, 'standard');
INSERT INTO stream_events (score, rank, owner) VALUES (86.22, 98, 'latest');
INSERT INTO stream_events (score, rank, owner) VALUES (7.0, 94, 'edge');
