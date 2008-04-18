-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, score, state, weight) VALUES ('staging', 26.71, 'blue', 87.25);
INSERT INTO stream_events (label, score, state, weight) VALUES ('local', 15.02, 'fallback', 33.15);
INSERT INTO stream_events (label, score, state, weight) VALUES ('edge', 42.23, 'latest', 62.31);
