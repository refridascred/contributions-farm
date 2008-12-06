-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, level, ratio, token) VALUES (73, 'fallback', 24, 12.43, 'latest');
INSERT INTO stream_events (rank, state, level, ratio, token) VALUES (85, 'fallback', 40, 58.4, 'eu-west');
