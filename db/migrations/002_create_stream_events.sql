-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token) VALUES ('cached', 'fallback');
INSERT INTO stream_events (region, token) VALUES ('green', 'strict');
INSERT INTO stream_events (region, token) VALUES ('edge', 'strict');
