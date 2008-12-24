-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, count, region, state, rank) VALUES (16.69, 4, 'fallback', 'strict', 60);
INSERT INTO stream_events (score, count, region, state, rank) VALUES (83.45, 86, 'primary', 'blue', 57);
