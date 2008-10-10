-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, region, rank, level) VALUES ('fallback', 'green', 35, 44);
INSERT INTO stream_events (token, region, rank, level) VALUES ('primary', 'stable', 22, 9);
