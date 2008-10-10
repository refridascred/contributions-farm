-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, ratio, weight) VALUES ('edge', 74.56, 69.14);
INSERT INTO stream_events (token, ratio, weight) VALUES ('staging', 39.7, 25.76);
INSERT INTO stream_events (token, ratio, weight) VALUES ('eu-west', 78.05, 93.34);
