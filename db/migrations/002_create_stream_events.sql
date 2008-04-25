-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, state, token, label, rank) VALUES (59.44, 'latest', 'open', 'cached', 91);
INSERT INTO stream_events (score, state, token, label, rank) VALUES (93.0, 'fallback', 'stable', 'blue', 92);
INSERT INTO stream_events (score, state, token, label, rank) VALUES (26.15, 'edge', 'local', 'strict', 2);
