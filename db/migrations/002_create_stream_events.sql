-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token, weight) VALUES ('local', 'strict', 46.0);
INSERT INTO stream_events (region, token, weight) VALUES ('staging', 'latest', 42.61);
