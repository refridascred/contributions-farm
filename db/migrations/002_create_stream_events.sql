-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, label, active) VALUES (45.74, 'cached', 12);
INSERT INTO stream_events (weight, label, active) VALUES (61.92, 'local', 27);
INSERT INTO stream_events (weight, label, active) VALUES (57.0, 'staging', 23);
