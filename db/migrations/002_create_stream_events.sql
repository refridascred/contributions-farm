-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, owner, state, rank) VALUES ('green', 'blue', 'stable', 'open', 24);
INSERT INTO stream_events (region, token, owner, state, rank) VALUES ('edge', 'green', 'legacy', 'open', 0);
INSERT INTO stream_events (region, token, owner, state, rank) VALUES ('eu-west', 'open', 'stable', 'green', 14);
