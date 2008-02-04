-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, label, ratio, level) VALUES (86.37, 'strict', 0.76, 43);
INSERT INTO stream_events (weight, label, ratio, level) VALUES (56.5, 'standard', 72.79, 66);
