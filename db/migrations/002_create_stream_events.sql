-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, ratio, count, rank, owner) VALUES ('strict', 12.89, 47, 47, 'strict');
INSERT INTO stream_events (state, ratio, count, rank, owner) VALUES ('legacy', 64.85, 52, 50, 'standard');
