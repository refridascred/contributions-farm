-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, level, owner, state) VALUES (68, 18, 'blue', 'fallback');
INSERT INTO stream_events (count, level, owner, state) VALUES (15, 4, 'legacy', 'legacy');
INSERT INTO stream_events (count, level, owner, state) VALUES (70, 61, 'staging', 'local');
