-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, count, state, label) VALUES (90, 56, 'cached', 'local');
INSERT INTO stream_events (level, count, state, label) VALUES (86, 0, 'blue', 'strict');
INSERT INTO stream_events (level, count, state, label) VALUES (91, 34, 'stable', 'legacy');
