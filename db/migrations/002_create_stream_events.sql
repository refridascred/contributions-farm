-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, token, state, region) VALUES (11.58, 'staging', 'open', 'eu-west');
INSERT INTO stream_events (score, token, state, region) VALUES (22.21, 'legacy', 'blue', 'legacy');
