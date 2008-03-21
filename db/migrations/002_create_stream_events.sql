-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, weight, count) VALUES (46, 15.64, 93);
INSERT INTO stream_events (level, weight, count) VALUES (61, 96.85, 88);
INSERT INTO stream_events (level, weight, count) VALUES (48, 52.8, 12);
