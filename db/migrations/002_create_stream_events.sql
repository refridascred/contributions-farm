-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, owner) VALUES (57, 11, 'open');
INSERT INTO stream_events (count, rank, owner) VALUES (28, 91, 'stable');
INSERT INTO stream_events (count, rank, owner) VALUES (82, 59, 'eu-west');
