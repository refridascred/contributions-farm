-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, ratio, score, weight) VALUES ('legacy', 68.08, 52.53, 23.05);
INSERT INTO stream_events (state, ratio, score, weight) VALUES ('legacy', 2.51, 69.55, 98.58);
INSERT INTO stream_events (state, ratio, score, weight) VALUES ('staging', 1.7, 98.3, 66.94);
