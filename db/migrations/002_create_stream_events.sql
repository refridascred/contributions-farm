-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, owner, rank, count) VALUES ('green', 'legacy', 'eu-west', 94, 89);
INSERT INTO stream_events (token, state, owner, rank, count) VALUES ('cached', 'blue', 'standard', 16, 11);
INSERT INTO stream_events (token, state, owner, rank, count) VALUES ('local', 'legacy', 'blue', 84, 70);
