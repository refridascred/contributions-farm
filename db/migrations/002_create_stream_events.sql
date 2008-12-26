-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, weight, label, region) VALUES (9.61, 'latest', 81.91, 'strict', 'primary');
INSERT INTO stream_events (score, owner, weight, label, region) VALUES (12.24, 'staging', 45.02, 'latest', 'fallback');
