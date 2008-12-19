-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, rank) VALUES (11.94, 84.48, 35);
INSERT INTO stream_events (weight, ratio, rank) VALUES (56.22, 15.21, 97);
INSERT INTO stream_events (weight, ratio, rank) VALUES (83.6, 79.65, 10);
