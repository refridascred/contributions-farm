-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, score, label, weight, state) VALUES (84, 60.43, 'blue', 57.38, 'blue');
INSERT INTO stream_events (count, score, label, weight, state) VALUES (63, 94.73, 'legacy', 45.0, 'edge');
