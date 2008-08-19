-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio) VALUES (33.09, 40.98);
INSERT INTO stream_events (weight, ratio) VALUES (11.66, 66.13);
INSERT INTO stream_events (weight, ratio) VALUES (80.09, 82.96);
