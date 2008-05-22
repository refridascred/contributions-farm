-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, active, level, region, label) VALUES (55.73, 53, 55, 'eu-west', 'green');
INSERT INTO stream_events (weight, active, level, region, label) VALUES (91.56, 82, 95, 'fallback', 'primary');
INSERT INTO stream_events (weight, active, level, region, label) VALUES (78.28, 16, 8, 'latest', 'fallback');
