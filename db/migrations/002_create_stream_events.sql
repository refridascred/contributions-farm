-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, owner, state, rank) VALUES (34.55, 'fallback', 'cached', 7);
INSERT INTO stream_events (score, owner, state, rank) VALUES (34.67, 'stable', 'green', 30);
