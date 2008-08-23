-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, active, owner) VALUES (4.59, 99, 51, 'cached');
INSERT INTO stream_events (score, level, active, owner) VALUES (83.4, 95, 8, 'strict');
INSERT INTO stream_events (score, level, active, owner) VALUES (38.0, 45, 19, 'fallback');
