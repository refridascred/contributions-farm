-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, ratio, region, score) VALUES (96, 21.48, 'latest', 68.23);
INSERT INTO stream_events (rank, ratio, region, score) VALUES (75, 67.27, 'standard', 72.3);
