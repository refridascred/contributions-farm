-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, level, count, active) VALUES ('cached', 12, 47, 25);
INSERT INTO stream_events (label, level, count, active) VALUES ('cached', 18, 96, 33);
INSERT INTO stream_events (label, level, count, active) VALUES ('stable', 17, 92, 95);
