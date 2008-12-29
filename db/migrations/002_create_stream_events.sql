-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, ratio, level) VALUES ('eu-west', 11.51, 86);
INSERT INTO stream_events (region, ratio, level) VALUES ('edge', 80.29, 59);
