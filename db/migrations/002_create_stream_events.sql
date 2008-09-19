-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, region, rank) VALUES (1.2, 'primary', 39);
INSERT INTO stream_events (weight, region, rank) VALUES (21.02, 'primary', 12);
INSERT INTO stream_events (weight, region, rank) VALUES (41.37, 'blue', 52);
