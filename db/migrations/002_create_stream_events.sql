-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, score, region, token, rank) VALUES ('primary', 13.84, 'fallback', 'latest', 33);
INSERT INTO stream_events (state, score, region, token, rank) VALUES ('staging', 0.08, 'primary', 'cached', 0);
