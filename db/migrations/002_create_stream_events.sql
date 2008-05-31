-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level) VALUES ('fallback', 15);
INSERT INTO stream_events (region, level) VALUES ('blue', 62);
INSERT INTO stream_events (region, level) VALUES ('stable', 29);
