-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, rank, active, region, owner) VALUES (37.19, 96, 60, 'strict', 'fallback');
INSERT INTO stream_events (score, rank, active, region, owner) VALUES (7.75, 89, 27, 'primary', 'cached');
INSERT INTO stream_events (score, rank, active, region, owner) VALUES (70.86, 40, 24, 'cached', 'green');
