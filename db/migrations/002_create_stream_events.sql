-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, rank, state, owner, count) VALUES ('standard', 74, 'stable', 'cached', 27);
INSERT INTO stream_events (token, rank, state, owner, count) VALUES ('fallback', 10, 'legacy', 'eu-west', 11);
INSERT INTO stream_events (token, rank, state, owner, count) VALUES ('eu-west', 2, 'legacy', 'local', 34);
