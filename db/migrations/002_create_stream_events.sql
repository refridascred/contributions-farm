-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, level, label, score, rank) VALUES (49, 6, 'standard', 78.57, 15);
INSERT INTO stream_events (count, level, label, score, rank) VALUES (32, 38, 'latest', 44.72, 56);
