-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, region, rank) VALUES (86.81, 'edge', 11);
INSERT INTO stream_events (ratio, region, rank) VALUES (72.96, 'latest', 86);
INSERT INTO stream_events (ratio, region, rank) VALUES (85.93, 'local', 88);
