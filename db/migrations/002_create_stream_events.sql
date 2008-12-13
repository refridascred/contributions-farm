-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, active, count, ratio) VALUES ('fallback', 27, 55, 17.84);
INSERT INTO stream_events (label, active, count, ratio) VALUES ('edge', 74, 28, 44.68);
