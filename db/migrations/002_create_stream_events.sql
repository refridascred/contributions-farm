-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, owner, token, state) VALUES (90, 'cached', 'legacy', 'stable');
INSERT INTO stream_events (active, owner, token, state) VALUES (27, 'green', 'fallback', 'standard');
INSERT INTO stream_events (active, owner, token, state) VALUES (69, 'stable', 'staging', 'open');
