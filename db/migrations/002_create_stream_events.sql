-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, active, ratio, label, token) VALUES (76.7, 83, 29.66, 'local', 'blue');
