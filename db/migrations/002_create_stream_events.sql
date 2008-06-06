-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, active, owner, state, rank) VALUES (75, 55, 'blue', 'primary', 95);
INSERT INTO stream_events (count, active, owner, state, rank) VALUES (53, 80, 'staging', 'edge', 61);
INSERT INTO stream_events (count, active, owner, state, rank) VALUES (98, 44, 'fallback', 'standard', 52);
