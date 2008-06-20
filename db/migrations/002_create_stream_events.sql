-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, token, state, score, owner) VALUES (25.61, 'primary', 'legacy', 28.97, 'open');
INSERT INTO stream_events (weight, token, state, score, owner) VALUES (53.73, 'local', 'latest', 73.66, 'open');
