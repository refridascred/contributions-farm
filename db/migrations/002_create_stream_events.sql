-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, label, active, count) VALUES (80, 'standard', 35, 57);
INSERT INTO stream_events (level, label, active, count) VALUES (41, 'blue', 92, 9);
INSERT INTO stream_events (level, label, active, count) VALUES (68, 'stable', 50, 6);
