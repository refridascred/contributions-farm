-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, state, score, owner) VALUES (75, 'green', 51.51, 'primary');
INSERT INTO stream_events (count, state, score, owner) VALUES (91, 'fallback', 64.15, 'open');
INSERT INTO stream_events (count, state, score, owner) VALUES (82, 'cached', 72.77, 'cached');
