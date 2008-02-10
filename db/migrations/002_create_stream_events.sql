-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, active, ratio, rank, state) VALUES ('open', 67, 40.24, 73, 'primary');
INSERT INTO stream_events (owner, active, ratio, rank, state) VALUES ('edge', 64, 77.52, 21, 'strict');
