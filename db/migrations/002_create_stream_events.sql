-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, score, level, region, rank) VALUES ('edge', 67.01, 66, 'blue', 75);
INSERT INTO stream_events (label, score, level, region, rank) VALUES ('latest', 98.01, 23, 'green', 42);
INSERT INTO stream_events (label, score, level, region, rank) VALUES ('local', 59.13, 68, 'open', 75);
