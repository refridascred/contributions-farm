-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, score) VALUES (25.74, 2.93, 80.39);
INSERT INTO stream_events (weight, ratio, score) VALUES (19.45, 36.3, 84.51);
INSERT INTO stream_events (weight, ratio, score) VALUES (51.58, 21.74, 3.33);
