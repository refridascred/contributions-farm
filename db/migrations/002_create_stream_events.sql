-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, state, score, weight) VALUES (11, 'eu-west', 7.79, 35.36);
INSERT INTO stream_events (rank, state, score, weight) VALUES (11, 'edge', 64.79, 28.18);
INSERT INTO stream_events (rank, state, score, weight) VALUES (77, 'stable', 67.48, 80.63);
