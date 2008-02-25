-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, owner, region, level) VALUES ('strict', 12.95, 'standard', 'legacy', 47);
INSERT INTO stream_events (label, score, owner, region, level) VALUES ('edge', 78.45, 'strict', 'blue', 95);
