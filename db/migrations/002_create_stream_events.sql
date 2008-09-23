-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, region, state, label, owner) VALUES (55, 'stable', 'cached', 'fallback', 'blue');
INSERT INTO stream_events (rank, region, state, label, owner) VALUES (98, 'legacy', 'green', 'blue', 'fallback');
