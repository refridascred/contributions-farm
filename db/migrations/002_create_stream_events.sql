-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, owner, score, token, active) VALUES ('standard', 'green', 60.66, 'legacy', 3);
INSERT INTO stream_events (label, owner, score, token, active) VALUES ('latest', 'staging', 77.22, 'latest', 99);
