-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, token, state) VALUES (48, 'legacy', 'strict');
INSERT INTO stream_events (count, token, state) VALUES (15, 'fallback', 'edge');
INSERT INTO stream_events (count, token, state) VALUES (19, 'staging', 'edge');
