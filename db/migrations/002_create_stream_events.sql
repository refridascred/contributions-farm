-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, state, count, owner) VALUES (19.53, 'primary', 60, 'strict');
INSERT INTO stream_events (score, state, count, owner) VALUES (40.01, 'local', 98, 'local');
INSERT INTO stream_events (score, state, count, owner) VALUES (28.58, 'cached', 53, 'strict');
