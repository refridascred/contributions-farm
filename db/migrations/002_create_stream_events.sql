-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, region) VALUES (77.24, 'staging');
INSERT INTO stream_events (ratio, region) VALUES (41.06, 'standard');
INSERT INTO stream_events (ratio, region) VALUES (23.53, 'legacy');
