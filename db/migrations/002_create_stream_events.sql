-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, state, rank, token) VALUES (41.83, 'edge', 31, 'open');
INSERT INTO stream_events (score, state, rank, token) VALUES (88.19, 'standard', 82, 'staging');
