-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, weight, label, region, token) VALUES (89, 98.39, 'primary', 'eu-west', 'standard');
INSERT INTO stream_events (count, weight, label, region, token) VALUES (38, 17.83, 'fallback', 'primary', 'open');
INSERT INTO stream_events (count, weight, label, region, token) VALUES (30, 21.03, 'green', 'primary', 'blue');
