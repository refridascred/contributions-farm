-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, count, state, level) VALUES (98, 50, 'staging', 55);
INSERT INTO stream_events (active, count, state, level) VALUES (40, 6, 'stable', 80);
INSERT INTO stream_events (active, count, state, level) VALUES (86, 2, 'strict', 24);
