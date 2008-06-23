-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, region, rank) VALUES ('blue', 9.07, 'legacy', 63);
INSERT INTO stream_events (label, score, region, rank) VALUES ('local', 41.36, 'staging', 43);
