-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, level, active, weight) VALUES ('edge', 31, 68, 42.15);
INSERT INTO stream_events (owner, level, active, weight) VALUES ('stable', 14, 29, 11.86);
