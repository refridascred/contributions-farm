-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, level) VALUES ('open', 49.19, 63);
INSERT INTO stream_events (region, ratio, level) VALUES ('blue', 42.43, 57);
INSERT INTO stream_events (region, ratio, level) VALUES ('open', 34.96, 20);
