-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, count, score, token) VALUES (39, 8, 8.98, 'green');
INSERT INTO stream_events (rank, count, score, token) VALUES (14, 68, 2.88, 'primary');
INSERT INTO stream_events (rank, count, score, token) VALUES (92, 13, 60.02, 'edge');
