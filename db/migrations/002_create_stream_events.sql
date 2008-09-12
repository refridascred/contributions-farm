-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, owner, score, ratio) VALUES ('staging', 'legacy', 41.86, 25.63);
INSERT INTO stream_events (state, owner, score, ratio) VALUES ('cached', 'fallback', 71.35, 96.1);
