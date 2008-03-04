-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, state, token) VALUES (50, 36.95, 'green', 'eu-west');
INSERT INTO stream_events (rank, ratio, state, token) VALUES (22, 64.84, 'open', 'edge');
