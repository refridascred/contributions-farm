-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, state, level, owner) VALUES ('latest', 22.33, 'legacy', 33, 'cached');
INSERT INTO stream_events (token, score, state, level, owner) VALUES ('eu-west', 11.37, 'latest', 45, 'cached');
