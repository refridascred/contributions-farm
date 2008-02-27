-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, label, score, level, token) VALUES ('standard', 'blue', 10.85, 61, 'strict');
INSERT INTO stream_events (owner, label, score, level, token) VALUES ('legacy', 'edge', 12.23, 18, 'primary');
