-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, level, weight) VALUES ('eu-west', 80, 69.86);
INSERT INTO stream_events (token, level, weight) VALUES ('primary', 4, 67.32);
