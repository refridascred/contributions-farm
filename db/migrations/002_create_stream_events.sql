-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, active, region, weight, label) VALUES (89, 18, 'green', 25.58, 'green');
INSERT INTO stream_events (level, active, region, weight, label) VALUES (76, 67, 'local', 39.7, 'cached');
INSERT INTO stream_events (level, active, region, weight, label) VALUES (28, 4, 'open', 23.45, 'latest');
