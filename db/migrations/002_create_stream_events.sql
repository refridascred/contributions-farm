-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, weight) VALUES (55, 63.19);
INSERT INTO stream_events (count, weight) VALUES (81, 55.29);
INSERT INTO stream_events (count, weight) VALUES (96, 19.01);
