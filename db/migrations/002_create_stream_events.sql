-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, rank, count) VALUES ('edge', 79, 11);
INSERT INTO stream_events (state, rank, count) VALUES ('standard', 37, 14);
INSERT INTO stream_events (state, rank, count) VALUES ('primary', 49, 24);
