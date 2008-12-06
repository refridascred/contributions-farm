-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, owner, state, token) VALUES (79, 84, 'green', 'legacy', 'stable');
INSERT INTO stream_events (count, rank, owner, state, token) VALUES (50, 40, 'cached', 'cached', 'latest');
INSERT INTO stream_events (count, rank, owner, state, token) VALUES (73, 34, 'edge', 'open', 'staging');
