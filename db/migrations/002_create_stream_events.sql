-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, owner) VALUES ('fallback', 36.92, 'strict');
INSERT INTO stream_events (region, score, owner) VALUES ('strict', 62.78, 'fallback');
INSERT INTO stream_events (region, score, owner) VALUES ('local', 39.1, 'cached');
