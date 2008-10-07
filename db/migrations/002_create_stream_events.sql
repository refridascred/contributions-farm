-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, weight, active, label, region) VALUES (56, 40.29, 7, 'cached', 'green');
INSERT INTO stream_events (count, weight, active, label, region) VALUES (78, 80.38, 48, 'eu-west', 'local');
INSERT INTO stream_events (count, weight, active, label, region) VALUES (76, 53.11, 36, 'fallback', 'standard');
