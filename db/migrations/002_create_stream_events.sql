-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, score, region) VALUES ('staging', 'staging', 30.13, 'stable');
INSERT INTO stream_events (state, token, score, region) VALUES ('standard', 'primary', 62.28, 'local');
