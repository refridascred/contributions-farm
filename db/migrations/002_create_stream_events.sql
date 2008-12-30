-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, score, token, region) VALUES ('open', 29.06, 'open', 'latest');
INSERT INTO stream_events (state, score, token, region) VALUES ('open', 92.68, 'strict', 'blue');
