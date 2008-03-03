-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, score, ratio, owner) VALUES (19, 92, 9.75, 46.76, 'blue');
INSERT INTO stream_events (count, rank, score, ratio, owner) VALUES (45, 91, 3.58, 42.17, 'cached');
INSERT INTO stream_events (count, rank, score, ratio, owner) VALUES (48, 41, 68.12, 8.03, 'fallback');
