-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, rank, state, owner) VALUES (67, 38, 'staging', 'fallback');
INSERT INTO stream_events (count, rank, state, owner) VALUES (48, 65, 'local', 'standard');
INSERT INTO stream_events (count, rank, state, owner) VALUES (33, 10, 'staging', 'fallback');
