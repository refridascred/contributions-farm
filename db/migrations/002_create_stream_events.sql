-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, score, active, token) VALUES ('legacy', 35.85, 48, 'open');
INSERT INTO stream_events (owner, score, active, token) VALUES ('local', 91.5, 42, 'cached');
INSERT INTO stream_events (owner, score, active, token) VALUES ('primary', 47.38, 27, 'fallback');
