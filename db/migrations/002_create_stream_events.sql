-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, level, ratio) VALUES (31.89, 38, 90.6);
INSERT INTO stream_events (weight, level, ratio) VALUES (7.97, 34, 24.95);
