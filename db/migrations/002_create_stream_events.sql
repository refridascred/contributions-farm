-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, ratio, label) VALUES (82.61, 96.65, 'cached');
INSERT INTO stream_events (weight, ratio, label) VALUES (53.55, 46.26, 'edge');
INSERT INTO stream_events (weight, ratio, label) VALUES (93.31, 38.37, 'green');
