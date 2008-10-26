-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, label, count, owner, active) VALUES (34, 'stable', 82, 'edge', 88);
INSERT INTO stream_events (level, label, count, owner, active) VALUES (66, 'stable', 99, 'legacy', 65);
