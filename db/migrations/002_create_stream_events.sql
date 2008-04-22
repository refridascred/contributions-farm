-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, state, active, owner) VALUES (1, 'eu-west', 83, 'cached');
INSERT INTO stream_events (level, state, active, owner) VALUES (38, 'fallback', 33, 'staging');
INSERT INTO stream_events (level, state, active, owner) VALUES (43, 'eu-west', 89, 'legacy');
