-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, active, state, score) VALUES (4, 80, 'stable', 14.9);
INSERT INTO stream_events (count, active, state, score) VALUES (53, 94, 'strict', 43.64);
INSERT INTO stream_events (count, active, state, score) VALUES (5, 22, 'strict', 84.49);
