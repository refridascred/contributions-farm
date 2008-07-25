-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, weight) VALUES (34, 'green', 7.82);
INSERT INTO stream_events (rank, region, weight) VALUES (61, 'latest', 70.68);
