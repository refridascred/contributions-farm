-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, region, state) VALUES ('strict', 'blue', 'eu-west');
INSERT INTO stream_events (label, region, state) VALUES ('primary', 'edge', 'green');
INSERT INTO stream_events (label, region, state) VALUES ('fallback', 'blue', 'staging');
