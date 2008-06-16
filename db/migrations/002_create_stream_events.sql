-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, token, score, region) VALUES (28, 'open', 'open', 61.98, 'local');
INSERT INTO stream_events (rank, state, token, score, region) VALUES (11, 'fallback', 'stable', 88.75, 'blue');
INSERT INTO stream_events (rank, state, token, score, region) VALUES (20, 'green', 'local', 39.94, 'latest');
