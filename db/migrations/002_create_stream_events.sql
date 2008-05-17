-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, weight, count, ratio, label) VALUES (24, 95.02, 89, 31.64, 'blue');
INSERT INTO stream_events (active, weight, count, ratio, label) VALUES (67, 85.33, 22, 54.35, 'edge');
INSERT INTO stream_events (active, weight, count, ratio, label) VALUES (33, 86.1, 95, 44.68, 'standard');
