-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, ratio, weight) VALUES (42, 45.79, 70.76);
INSERT INTO stream_events (active, ratio, weight) VALUES (12, 60.99, 97.12);
