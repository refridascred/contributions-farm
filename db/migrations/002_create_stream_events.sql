-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, score, token, region) VALUES ('fallback', 32.13, 'blue', 'edge');
INSERT INTO stream_events (state, score, token, region) VALUES ('staging', 98.66, 'eu-west', 'latest');
