-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, active, score, count) VALUES (82, 22, 40.18, 78);
INSERT INTO stream_events (level, active, score, count) VALUES (64, 84, 36.62, 55);
INSERT INTO stream_events (level, active, score, count) VALUES (29, 70, 47.96, 41);
