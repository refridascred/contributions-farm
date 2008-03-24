-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, active, token) VALUES ('open', 94.76, 7, 'primary');
INSERT INTO stream_events (label, score, active, token) VALUES ('local', 36.75, 70, 'strict');
INSERT INTO stream_events (label, score, active, token) VALUES ('open', 61.01, 32, 'eu-west');
