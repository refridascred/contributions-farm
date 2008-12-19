-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, count) VALUES (21.09, 51);
INSERT INTO stream_events (weight, count) VALUES (57.19, 86);
INSERT INTO stream_events (weight, count) VALUES (4.4, 10);
