-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, weight, active) VALUES (51.17, 83.87, 83);
INSERT INTO stream_events (ratio, weight, active) VALUES (36.02, 88.04, 84);
INSERT INTO stream_events (ratio, weight, active) VALUES (24.16, 57.88, 88);
