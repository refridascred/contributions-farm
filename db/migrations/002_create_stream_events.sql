-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, level) VALUES (15, 70.84, 87);
INSERT INTO stream_events (active, weight, level) VALUES (54, 29.18, 73);
INSERT INTO stream_events (active, weight, level) VALUES (96, 36.9, 40);
