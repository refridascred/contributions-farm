-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, token) VALUES (70, 'local', 'edge');
INSERT INTO stream_events (level, owner, token) VALUES (78, 'strict', 'fallback');
INSERT INTO stream_events (level, owner, token) VALUES (50, 'strict', 'edge');
