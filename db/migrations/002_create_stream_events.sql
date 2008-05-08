-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, owner, active, level, score) VALUES ('stable', 'green', 45, 12, 26.15);
INSERT INTO stream_events (region, owner, active, level, score) VALUES ('standard', 'edge', 4, 98, 39.0);
