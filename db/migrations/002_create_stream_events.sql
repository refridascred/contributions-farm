-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, count, active, score, level) VALUES ('standard', 40, 77, 83.92, 58);
INSERT INTO stream_events (token, count, active, score, level) VALUES ('legacy', 93, 78, 18.84, 8);
