-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, score, token, ratio) VALUES (54, 54.6, 'stable', 82.14);
INSERT INTO stream_events (rank, score, token, ratio) VALUES (80, 16.94, 'latest', 92.64);
INSERT INTO stream_events (rank, score, token, ratio) VALUES (82, 57.63, 'eu-west', 82.05);
