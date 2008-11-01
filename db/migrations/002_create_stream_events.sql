-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, token, rank, score) VALUES (7, 'fallback', 46, 5.02);
INSERT INTO stream_events (active, token, rank, score) VALUES (3, 'stable', 98, 72.25);
INSERT INTO stream_events (active, token, rank, score) VALUES (67, 'eu-west', 82, 14.06);
