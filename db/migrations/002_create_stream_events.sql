-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, state, weight, ratio) VALUES (70.35, 'edge', 96.55, 31.97);
INSERT INTO stream_events (score, state, weight, ratio) VALUES (51.79, 'cached', 73.58, 96.17);
