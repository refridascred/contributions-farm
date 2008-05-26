-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, rank, state, level) VALUES ('blue', 28, 'edge', 94);
INSERT INTO stream_events (owner, rank, state, level) VALUES ('green', 61, 'fallback', 25);
INSERT INTO stream_events (owner, rank, state, level) VALUES ('standard', 79, 'standard', 5);
