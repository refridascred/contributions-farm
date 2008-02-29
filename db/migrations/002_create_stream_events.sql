-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, score, active, owner) VALUES ('blue', 11.25, 34, 'staging');
INSERT INTO stream_events (token, score, active, owner) VALUES ('stable', 74.52, 76, 'blue');
