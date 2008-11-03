-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, owner, ratio) VALUES ('stable', 'strict', 'latest', 8.42);
INSERT INTO stream_events (token, state, owner, ratio) VALUES ('green', 'local', 'legacy', 19.84);
