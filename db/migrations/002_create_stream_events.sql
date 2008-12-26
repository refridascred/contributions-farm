-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count) VALUES (65.18, 30);
INSERT INTO stream_events (weight, count) VALUES (23.53, 33);
INSERT INTO stream_events (weight, count) VALUES (3.04, 26);
