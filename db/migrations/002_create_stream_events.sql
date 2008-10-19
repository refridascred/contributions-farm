-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, active, state, token) VALUES (77, 9, 'stable', 'primary');
INSERT INTO stream_events (count, active, state, token) VALUES (35, 88, 'eu-west', 'standard');
INSERT INTO stream_events (count, active, state, token) VALUES (41, 18, 'stable', 'eu-west');
