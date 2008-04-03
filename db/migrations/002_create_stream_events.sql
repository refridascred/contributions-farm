-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, active, level, score, token) VALUES (27, 14, 34, 43.52, 'edge');
INSERT INTO stream_events (rank, active, level, score, token) VALUES (11, 61, 38, 35.33, 'local');
INSERT INTO stream_events (rank, active, level, score, token) VALUES (90, 3, 19, 8.71, 'eu-west');
