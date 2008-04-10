-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, active, rank) VALUES ('open', 'standard', 28, 21);
INSERT INTO stream_events (owner, state, active, rank) VALUES ('strict', 'stable', 42, 60);
INSERT INTO stream_events (owner, state, active, rank) VALUES ('standard', 'fallback', 15, 9);
