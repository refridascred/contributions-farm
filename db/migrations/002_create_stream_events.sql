-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, weight, count, ratio) VALUES ('standard', 94.14, 84, 67.23);
INSERT INTO stream_events (label, weight, count, ratio) VALUES ('strict', 66.06, 96, 51.16);
INSERT INTO stream_events (label, weight, count, ratio) VALUES ('primary', 57.24, 96, 19.24);
