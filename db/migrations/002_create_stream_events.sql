-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count) VALUES ('edge', 93);
INSERT INTO stream_events (label, count) VALUES ('strict', 44);
INSERT INTO stream_events (label, count) VALUES ('fallback', 73);
