-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, active, weight) VALUES (23, 20, 2.78);
INSERT INTO stream_events (count, active, weight) VALUES (74, 6, 15.48);
INSERT INTO stream_events (count, active, weight) VALUES (17, 52, 42.19);
