-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, region, token, score) VALUES ('open', 'strict', 'eu-west', 39.47);
INSERT INTO stream_events (state, region, token, score) VALUES ('standard', 'cached', 'staging', 21.85);
