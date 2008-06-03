-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, owner, count, ratio, active) VALUES (51, 'fallback', 96, 97.41, 84);
INSERT INTO stream_events (level, owner, count, ratio, active) VALUES (3, 'stable', 32, 13.98, 57);
