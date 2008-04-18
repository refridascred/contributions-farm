-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, state, count, owner, rank) VALUES ('fallback', 'edge', 8, 'blue', 5);
INSERT INTO stream_events (token, state, count, owner, rank) VALUES ('cached', 'green', 33, 'open', 61);
INSERT INTO stream_events (token, state, count, owner, rank) VALUES ('staging', 'strict', 4, 'latest', 74);
