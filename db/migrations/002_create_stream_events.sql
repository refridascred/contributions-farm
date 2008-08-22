-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, active, region) VALUES ('edge', 'cached', 29, 'stable');
INSERT INTO stream_events (state, token, active, region) VALUES ('blue', 'eu-west', 80, 'strict');
