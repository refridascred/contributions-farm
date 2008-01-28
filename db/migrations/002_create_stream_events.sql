-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, score, state, label) VALUES (43, 67.56, 'latest', 'stable');
INSERT INTO stream_events (rank, score, state, label) VALUES (24, 14.53, 'primary', 'standard');
INSERT INTO stream_events (rank, score, state, label) VALUES (23, 54.89, 'latest', 'stable');
