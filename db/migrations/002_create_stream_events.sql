-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, active) VALUES (61.58, 'primary', 89);
INSERT INTO stream_events (score, token, active) VALUES (88.31, 'legacy', 7);
INSERT INTO stream_events (score, token, active) VALUES (78.72, 'staging', 44);
