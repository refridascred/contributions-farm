-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, ratio, token, region) VALUES (96, 89, 80.07, 'open', 'blue');
INSERT INTO stream_events (count, rank, ratio, token, region) VALUES (32, 14, 20.44, 'green', 'latest');
INSERT INTO stream_events (count, rank, ratio, token, region) VALUES (42, 67, 71.12, 'stable', 'stable');
