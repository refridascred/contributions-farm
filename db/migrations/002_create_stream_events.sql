-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, label, score) VALUES (2, 54, 'legacy', 34.26);
INSERT INTO stream_events (level, rank, label, score) VALUES (7, 99, 'stable', 19.96);
