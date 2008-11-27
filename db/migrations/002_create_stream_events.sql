-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, level, ratio, weight) VALUES ('cached', 89, 65.65, 11.85);
INSERT INTO stream_events (token, level, ratio, weight) VALUES ('blue', 19, 51.97, 38.07);
