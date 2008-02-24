-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, state, owner) VALUES (98, 'fallback', 'latest');
INSERT INTO stream_events (active, state, owner) VALUES (92, 'standard', 'fallback');
INSERT INTO stream_events (active, state, owner) VALUES (18, 'latest', 'latest');
