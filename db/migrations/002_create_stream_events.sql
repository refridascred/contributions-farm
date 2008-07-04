-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, active, level, state) VALUES (17.13, 77, 37, 'strict');
INSERT INTO stream_events (score, active, level, state) VALUES (94.58, 5, 50, 'eu-west');
INSERT INTO stream_events (score, active, level, state) VALUES (41.31, 7, 98, 'open');
