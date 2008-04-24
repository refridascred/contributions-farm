-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, score, level, owner) VALUES ('edge', 17.1, 59, 'latest');
INSERT INTO stream_events (region, score, level, owner) VALUES ('standard', 29.15, 9, 'primary');
