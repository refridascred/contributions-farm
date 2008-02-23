-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, label, score, weight) VALUES ('stable', 'stable', 93.88, 53.23);
INSERT INTO stream_events (state, label, score, weight) VALUES ('standard', 'fallback', 62.25, 34.04);
INSERT INTO stream_events (state, label, score, weight) VALUES ('stable', 'legacy', 76.24, 19.24);
