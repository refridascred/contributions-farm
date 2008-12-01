-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, level, weight, count) VALUES ('cached', 80, 17.25, 79);
INSERT INTO stream_events (label, level, weight, count) VALUES ('green', 82, 75.94, 33);
INSERT INTO stream_events (label, level, weight, count) VALUES ('latest', 57, 16.33, 85);
