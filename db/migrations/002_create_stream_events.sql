-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, owner, token) VALUES (31, 'fallback', 'open');
INSERT INTO stream_events (active, owner, token) VALUES (16, 'legacy', 'blue');
INSERT INTO stream_events (active, owner, token) VALUES (2, 'blue', 'staging');
