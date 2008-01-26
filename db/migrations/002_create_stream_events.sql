-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, token, ratio, rank, count) VALUES ('stable', 'green', 9.01, 33, 19);
INSERT INTO stream_events (region, token, ratio, rank, count) VALUES ('local', 'edge', 48.91, 5, 20);
