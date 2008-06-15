-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, score, level, rank, ratio) VALUES ('standard', 24.71, 38, 98, 66.57);
INSERT INTO stream_events (region, score, level, rank, ratio) VALUES ('staging', 91.4, 96, 66, 13.32);
