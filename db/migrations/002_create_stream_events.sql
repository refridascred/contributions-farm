-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, ratio, rank, state, owner) VALUES ('edge', 2.46, 76, 'standard', 'green');
INSERT INTO stream_events (token, ratio, rank, state, owner) VALUES ('staging', 93.85, 97, 'primary', 'blue');
INSERT INTO stream_events (token, ratio, rank, state, owner) VALUES ('strict', 28.6, 32, 'legacy', 'stable');
