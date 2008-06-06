-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, level, ratio) VALUES (70.62, 10, 73.09);
INSERT INTO stream_events (weight, level, ratio) VALUES (23.31, 92, 8.59);
INSERT INTO stream_events (weight, level, ratio) VALUES (88.98, 25, 45.13);
