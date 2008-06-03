-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, active, count, state, owner) VALUES (96, 52, 30, 'eu-west', 'staging');
INSERT INTO stream_events (level, active, count, state, owner) VALUES (22, 57, 0, 'primary', 'strict');
INSERT INTO stream_events (level, active, count, state, owner) VALUES (74, 23, 64, 'staging', 'stable');
