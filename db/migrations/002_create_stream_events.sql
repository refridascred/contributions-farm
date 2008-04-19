-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token) VALUES ('legacy', 'strict');
INSERT INTO stream_events (region, token) VALUES ('stable', 'stable');
INSERT INTO stream_events (region, token) VALUES ('blue', 'strict');
