-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, ratio, state) VALUES (38, 13.41, 37.56, 'strict');
INSERT INTO stream_events (active, score, ratio, state) VALUES (90, 49.77, 62.61, 'strict');
INSERT INTO stream_events (active, score, ratio, state) VALUES (52, 77.98, 0.87, 'standard');
