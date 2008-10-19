-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, state, weight) VALUES (11.62, 67.31, 'edge', 73.7);
INSERT INTO stream_events (ratio, score, state, weight) VALUES (83.47, 8.0, 'latest', 87.77);
