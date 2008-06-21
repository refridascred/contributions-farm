-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, count) VALUES (21, 'primary', 92);
INSERT INTO stream_events (level, label, count) VALUES (6, 'stable', 2);
INSERT INTO stream_events (level, label, count) VALUES (62, 'green', 47);
