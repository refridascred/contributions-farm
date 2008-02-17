-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, level, active) VALUES (60, 6, 18);
INSERT INTO stream_events (count, level, active) VALUES (12, 78, 68);
