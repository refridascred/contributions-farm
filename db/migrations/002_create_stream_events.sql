-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, state, owner) VALUES (31.33, 'open', 'staging');
INSERT INTO stream_events (ratio, state, owner) VALUES (28.54, 'fallback', 'strict');
INSERT INTO stream_events (ratio, state, owner) VALUES (94.29, 'cached', 'standard');
