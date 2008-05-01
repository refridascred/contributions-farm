-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, token) VALUES ('latest', 'edge', 'local');
INSERT INTO stream_events (region, state, token) VALUES ('blue', 'staging', 'eu-west');
