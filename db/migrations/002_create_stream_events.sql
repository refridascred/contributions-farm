-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, count, ratio) VALUES (44.65, 22, 79.73);
INSERT INTO stream_events (weight, count, ratio) VALUES (87.04, 57, 64.55);
INSERT INTO stream_events (weight, count, ratio) VALUES (26.74, 98, 35.27);
