-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, active) VALUES (31, 25);
INSERT INTO stream_events (level, active) VALUES (78, 89);
INSERT INTO stream_events (level, active) VALUES (2, 6);
