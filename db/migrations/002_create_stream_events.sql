-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, ratio, rank) VALUES ('eu-west', 49.0, 70);
INSERT INTO stream_events (region, ratio, rank) VALUES ('open', 41.68, 98);
