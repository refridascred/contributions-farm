-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, label, level, rank) VALUES (96.36, 'latest', 25, 5);
INSERT INTO stream_events (score, label, level, rank) VALUES (11.01, 'stable', 72, 47);
