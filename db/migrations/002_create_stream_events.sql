-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, count) VALUES (74, 39);
INSERT INTO stream_events (level, count) VALUES (15, 20);
INSERT INTO stream_events (level, count) VALUES (30, 63);
