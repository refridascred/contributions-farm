-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, active, owner) VALUES (76.49, 79.51, 9, 'stable');
INSERT INTO stream_events (weight, ratio, active, owner) VALUES (92.91, 40.65, 72, 'local');
