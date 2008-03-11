-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, state, label, token) VALUES (98.03, 'blue', 'open', 'primary');
INSERT INTO stream_events (score, state, label, token) VALUES (77.46, 'fallback', 'cached', 'primary');
INSERT INTO stream_events (score, state, label, token) VALUES (63.92, 'standard', 'stable', 'eu-west');
