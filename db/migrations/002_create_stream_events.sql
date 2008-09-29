-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, state, owner, region) VALUES ('eu-west', 18, 'blue', 'open', 'blue');
INSERT INTO stream_events (token, count, state, owner, region) VALUES ('staging', 42, 'blue', 'open', 'strict');
