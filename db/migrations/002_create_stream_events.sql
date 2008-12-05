-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, count, ratio, rank) VALUES (77.26, 14, 21.69, 25);
INSERT INTO stream_events (weight, count, ratio, rank) VALUES (36.77, 44, 69.65, 97);
INSERT INTO stream_events (weight, count, ratio, rank) VALUES (65.4, 66, 80.98, 26);
