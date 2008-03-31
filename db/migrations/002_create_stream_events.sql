-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, count) VALUES (95.58, 65);
INSERT INTO stream_events (weight, count) VALUES (80.67, 58);
INSERT INTO stream_events (weight, count) VALUES (40.16, 51);
