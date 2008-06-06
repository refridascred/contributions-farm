-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, count, score) VALUES ('staging', 'local', 60, 30.19);
INSERT INTO stream_events (owner, state, count, score) VALUES ('cached', 'latest', 16, 54.81);
INSERT INTO stream_events (owner, state, count, score) VALUES ('edge', 'open', 52, 4.47);
