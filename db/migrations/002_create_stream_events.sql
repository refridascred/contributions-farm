-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, token, score, owner, active) VALUES ('stable', 'open', 81.21, 'local', 6);
INSERT INTO stream_events (label, token, score, owner, active) VALUES ('open', 'stable', 52.84, 'primary', 60);
