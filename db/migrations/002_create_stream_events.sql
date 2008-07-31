-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, token, ratio) VALUES (41.64, 'staging', 49.47);
INSERT INTO stream_events (weight, token, ratio) VALUES (55.74, 'edge', 97.84);
