-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, ratio, weight, active, rank) VALUES ('eu-west', 3.81, 86.78, 67, 60);
INSERT INTO stream_events (label, ratio, weight, active, rank) VALUES ('eu-west', 67.25, 69.2, 81, 87);
