-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, state, token, score, rank) VALUES (30.51, 'cached', 'primary', 50.19, 6);
INSERT INTO stream_events (weight, state, token, score, rank) VALUES (92.34, 'cached', 'cached', 0.53, 72);
