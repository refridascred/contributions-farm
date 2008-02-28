-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, weight, rank, count, region) VALUES ('open', 83.8, 70, 0, 'local');
INSERT INTO stream_events (label, weight, rank, count, region) VALUES ('edge', 61.37, 11, 47, 'primary');
