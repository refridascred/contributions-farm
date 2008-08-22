-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, score, level) VALUES (60.72, 94.08, 52);
INSERT INTO stream_events (ratio, score, level) VALUES (79.52, 57.31, 36);
