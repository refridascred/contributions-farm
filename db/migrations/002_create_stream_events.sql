-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, region) VALUES (16, 'edge');
INSERT INTO stream_events (level, region) VALUES (2, 'edge');
INSERT INTO stream_events (level, region) VALUES (78, 'blue');
