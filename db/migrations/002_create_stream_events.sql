-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, label, rank) VALUES (0.1, 'legacy', 51);
INSERT INTO stream_events (weight, label, rank) VALUES (41.02, 'staging', 69);
INSERT INTO stream_events (weight, label, rank) VALUES (65.57, 'staging', 65);
