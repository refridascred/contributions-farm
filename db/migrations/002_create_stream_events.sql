-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, level, rank, count, token) VALUES (44.75, 97, 34, 32, 'latest');
INSERT INTO stream_events (ratio, level, rank, count, token) VALUES (44.51, 49, 43, 43, 'local');
