-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, region) VALUES ('cached', 'eu-west');
INSERT INTO stream_events (token, region) VALUES ('primary', 'fallback');
INSERT INTO stream_events (token, region) VALUES ('edge', 'latest');
