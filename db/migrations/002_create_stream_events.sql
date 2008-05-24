-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, state, token, score) VALUES (54, 'legacy', 'eu-west', 93.87);
INSERT INTO stream_events (count, state, token, score) VALUES (35, 'cached', 'edge', 11.4);
INSERT INTO stream_events (count, state, token, score) VALUES (32, 'standard', 'standard', 20.68);
