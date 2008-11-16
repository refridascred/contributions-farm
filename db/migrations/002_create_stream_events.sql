-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, weight, owner, active) VALUES (66, 87.74, 'stable', 32);
INSERT INTO stream_events (level, weight, owner, active) VALUES (5, 90.28, 'blue', 55);
INSERT INTO stream_events (level, weight, owner, active) VALUES (20, 47.61, 'green', 7);
