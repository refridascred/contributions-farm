-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, rank, count) VALUES ('stable', 14, 54);
INSERT INTO stream_events (state, rank, count) VALUES ('legacy', 29, 98);
INSERT INTO stream_events (state, rank, count) VALUES ('latest', 28, 60);
