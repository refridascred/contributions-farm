-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, region) VALUES ('staging', 'legacy');
INSERT INTO stream_events (token, region) VALUES ('staging', 'local');
INSERT INTO stream_events (token, region) VALUES ('staging', 'fallback');
