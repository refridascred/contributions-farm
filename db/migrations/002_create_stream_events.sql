-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, ratio, state, owner) VALUES (74.82, 12.29, 'local', 'standard');
