-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, owner) VALUES (96.32, 61, 'open');
INSERT INTO stream_events (ratio, rank, owner) VALUES (88.26, 89, 'blue');
