-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, region, score) VALUES (26.55, 43, 'open', 18.12);
INSERT INTO stream_events (ratio, rank, region, score) VALUES (39.28, 68, 'eu-west', 79.13);
