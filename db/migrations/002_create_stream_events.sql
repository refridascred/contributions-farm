-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, ratio, rank, count) VALUES ('eu-west', 57.91, 86, 88);
INSERT INTO stream_events (token, ratio, rank, count) VALUES ('eu-west', 62.32, 60, 3);
