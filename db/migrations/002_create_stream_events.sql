-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, state, token) VALUES (3.32, 'local', 'blue');
INSERT INTO stream_events (score, state, token) VALUES (43.28, 'staging', 'standard');
INSERT INTO stream_events (score, state, token) VALUES (49.46, 'strict', 'staging');
