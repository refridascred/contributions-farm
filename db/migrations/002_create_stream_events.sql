-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, count, ratio, weight) VALUES (98, 19, 68.87, 49.2);
INSERT INTO stream_events (active, count, ratio, weight) VALUES (46, 99, 94.86, 0.7);
INSERT INTO stream_events (active, count, ratio, weight) VALUES (36, 45, 1.23, 26.09);
