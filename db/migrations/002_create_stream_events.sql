-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, count, ratio, active) VALUES ('strict', 69, 63.9, 70);
INSERT INTO stream_events (region, count, ratio, active) VALUES ('fallback', 15, 78.16, 64);
INSERT INTO stream_events (region, count, ratio, active) VALUES ('local', 57, 4.44, 15);
