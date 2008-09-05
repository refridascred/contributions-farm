-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, level, count) VALUES ('local', 93, 42);
INSERT INTO stream_events (label, level, count) VALUES ('edge', 61, 5);
INSERT INTO stream_events (label, level, count) VALUES ('local', 14, 0);
