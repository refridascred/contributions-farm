-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, owner, token, score) VALUES ('primary', 'local', 'edge', 83.75);
INSERT INTO stream_events (state, owner, token, score) VALUES ('cached', 'primary', 'fallback', 35.48);
INSERT INTO stream_events (state, owner, token, score) VALUES ('edge', 'blue', 'latest', 15.13);
