-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, token) VALUES (84, 21.46, 'strict');
INSERT INTO stream_events (active, score, token) VALUES (81, 33.82, 'open');
INSERT INTO stream_events (active, score, token) VALUES (6, 17.66, 'eu-west');
