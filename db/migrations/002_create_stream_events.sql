-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, state, score, token) VALUES ('cached', 26.2, 'green', 95.84, 'edge');
INSERT INTO stream_events (label, weight, state, score, token) VALUES ('stable', 39.56, 'blue', 56.26, 'blue');
