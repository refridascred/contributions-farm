-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, count, rank, score, region) VALUES ('stable', 26, 95, 91.01, 'blue');
INSERT INTO stream_events (label, count, rank, score, region) VALUES ('latest', 78, 47, 62.55, 'standard');
