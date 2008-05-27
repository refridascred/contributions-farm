-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, state, owner) VALUES (87.64, 75.36, 'stable', 'green');
INSERT INTO stream_events (score, weight, state, owner) VALUES (76.62, 23.49, 'strict', 'green');
INSERT INTO stream_events (score, weight, state, owner) VALUES (69.67, 9.53, 'edge', 'cached');
