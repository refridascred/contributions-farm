-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, ratio) VALUES ('staging', 82.25, 2.97);
INSERT INTO stream_events (label, weight, ratio) VALUES ('primary', 68.1, 25.47);
INSERT INTO stream_events (label, weight, ratio) VALUES ('legacy', 89.06, 49.29);
