-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, region) VALUES (51.92, 43, 'latest');
INSERT INTO stream_events (weight, rank, region) VALUES (19.62, 26, 'strict');
