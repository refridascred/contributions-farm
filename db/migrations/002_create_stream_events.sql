-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, weight) VALUES (24, 5.28, 81.07);
INSERT INTO stream_events (count, ratio, weight) VALUES (56, 14.83, 53.25);
INSERT INTO stream_events (count, ratio, weight) VALUES (47, 20.09, 95.29);
