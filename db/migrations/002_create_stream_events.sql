-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, weight, ratio) VALUES ('cached', 24.43, 45.63);
INSERT INTO stream_events (token, weight, ratio) VALUES ('strict', 85.54, 17.04);
