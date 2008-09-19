-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count) VALUES (62, 65);
INSERT INTO stream_events (level, count) VALUES (34, 53);
INSERT INTO stream_events (level, count) VALUES (42, 87);
