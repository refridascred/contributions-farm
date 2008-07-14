-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, weight, owner) VALUES (44, 42.17, 'primary');
INSERT INTO stream_events (rank, weight, owner) VALUES (58, 21.01, 'latest');
INSERT INTO stream_events (rank, weight, owner) VALUES (57, 49.34, 'primary');
