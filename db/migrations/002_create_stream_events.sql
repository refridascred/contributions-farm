-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, state, count, level, active) VALUES ('staging', 'legacy', 61, 48, 63);
INSERT INTO stream_events (owner, state, count, level, active) VALUES ('edge', 'blue', 23, 24, 54);
INSERT INTO stream_events (owner, state, count, level, active) VALUES ('edge', 'cached', 79, 59, 90);
