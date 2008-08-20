-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, count) VALUES ('eu-west', 33.27, 13);
INSERT INTO stream_events (label, weight, count) VALUES ('green', 89.31, 83);
