-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, ratio, label, owner) VALUES (29.66, 66.46, 'eu-west', 'local');
INSERT INTO stream_events (weight, ratio, label, owner) VALUES (32.04, 44.83, 'green', 'cached');
INSERT INTO stream_events (weight, ratio, label, owner) VALUES (49.84, 69.63, 'standard', 'cached');
