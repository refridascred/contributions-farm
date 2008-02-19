-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, count, rank, state) VALUES ('edge', 25, 99, 'staging');
INSERT INTO stream_events (owner, count, rank, state) VALUES ('green', 45, 8, 'edge');
INSERT INTO stream_events (owner, count, rank, state) VALUES ('legacy', 84, 18, 'blue');
