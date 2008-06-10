-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, state, score, ratio, region) VALUES ('legacy', 'cached', 34.39, 31.62, 'legacy');
INSERT INTO stream_events (owner, state, score, ratio, region) VALUES ('open', 'legacy', 59.19, 35.17, 'cached');
INSERT INTO stream_events (owner, state, score, ratio, region) VALUES ('fallback', 'blue', 39.13, 35.58, 'edge');
