-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, ratio) VALUES (95, 50.58, 61.49);
INSERT INTO stream_events (count, weight, ratio) VALUES (17, 29.78, 27.64);
INSERT INTO stream_events (count, weight, ratio) VALUES (23, 65.21, 30.16);
