-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, weight, level, count) VALUES ('strict', 79.41, 76, 43);
INSERT INTO stream_events (label, weight, level, count) VALUES ('eu-west', 10.99, 55, 33);
