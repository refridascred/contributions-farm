-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, token, region, score) VALUES ('blue', 'primary', 'staging', 43.55);
INSERT INTO stream_events (owner, token, region, score) VALUES ('standard', 'legacy', 'open', 33.48);
INSERT INTO stream_events (owner, token, region, score) VALUES ('primary', 'latest', 'fallback', 18.76);
