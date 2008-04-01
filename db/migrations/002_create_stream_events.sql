-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, score, token) VALUES ('primary', 92.06, 'blue');
INSERT INTO stream_events (state, score, token) VALUES ('cached', 4.11, 'local');
INSERT INTO stream_events (state, score, token) VALUES ('edge', 84.95, 'edge');
