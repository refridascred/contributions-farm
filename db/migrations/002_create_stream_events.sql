-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, level, ratio) VALUES ('green', 12, 90.59);
INSERT INTO stream_events (region, level, ratio) VALUES ('primary', 51, 34.0);
