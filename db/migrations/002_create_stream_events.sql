-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, score, owner, level) VALUES ('standard', 49.16, 'green', 25);
INSERT INTO stream_events (region, score, owner, level) VALUES ('fallback', 54.46, 'cached', 56);
INSERT INTO stream_events (region, score, owner, level) VALUES ('fallback', 97.11, 'blue', 87);
