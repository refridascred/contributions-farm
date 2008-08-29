-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, active, label) VALUES (38.04, 17, 'edge');
INSERT INTO stream_events (weight, active, label) VALUES (5.82, 25, 'latest');
INSERT INTO stream_events (weight, active, label) VALUES (48.89, 21, 'blue');
