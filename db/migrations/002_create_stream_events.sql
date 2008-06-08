-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight) VALUES ('latest', 0.67);
INSERT INTO stream_events (label, weight) VALUES ('local', 69.57);
INSERT INTO stream_events (label, weight) VALUES ('eu-west', 51.9);
