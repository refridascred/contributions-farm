-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, level) VALUES (60, 30.16, 57);
INSERT INTO stream_events (active, weight, level) VALUES (77, 45.32, 62);
INSERT INTO stream_events (active, weight, level) VALUES (90, 6.06, 57);
