-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, state, score) VALUES (6.08, 'legacy', 68.24);
INSERT INTO stream_events (weight, state, score) VALUES (69.36, 'blue', 35.76);
INSERT INTO stream_events (weight, state, score) VALUES (60.32, 'strict', 23.77);
