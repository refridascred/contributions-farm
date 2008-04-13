-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, owner, state, region) VALUES (40, 'primary', 'blue', 'strict');
INSERT INTO stream_events (active, owner, state, region) VALUES (14, 'edge', 'primary', 'eu-west');
