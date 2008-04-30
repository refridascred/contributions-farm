-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, score, state, token, owner) VALUES ('stable', 29.07, 'staging', 'blue', 'legacy');
INSERT INTO stream_events (label, score, state, token, owner) VALUES ('staging', 36.58, 'blue', 'eu-west', 'green');
