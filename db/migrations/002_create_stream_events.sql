-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, state, count, owner, score) VALUES ('edge', 'staging', 47, 'strict', 64.19);
INSERT INTO stream_events (token, state, count, owner, score) VALUES ('legacy', 'local', 83, 'green', 54.8);
INSERT INTO stream_events (token, state, count, owner, score) VALUES ('standard', 'strict', 19, 'strict', 76.9);
