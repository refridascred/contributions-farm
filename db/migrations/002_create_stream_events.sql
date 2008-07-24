-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, level, ratio, count) VALUES ('latest', 85, 21.13, 51);
INSERT INTO stream_events (label, level, ratio, count) VALUES ('strict', 20, 82.81, 20);
