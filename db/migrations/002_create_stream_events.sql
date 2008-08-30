-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, score, token, active, level) VALUES (12, 16.99, 'edge', 86, 93);
INSERT INTO stream_events (rank, score, token, active, level) VALUES (14, 84.57, 'cached', 39, 40);
