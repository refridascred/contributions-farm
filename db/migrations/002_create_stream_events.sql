-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, active, state, owner, weight) VALUES (78.26, 50, 'legacy', 'stable', 36.14);
INSERT INTO stream_events (score, active, state, owner, weight) VALUES (31.14, 37, 'cached', 'legacy', 26.76);
