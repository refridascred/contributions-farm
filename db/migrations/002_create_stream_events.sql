-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, region) VALUES ('local', 'edge');
INSERT INTO stream_events (state, region) VALUES ('staging', 'cached');
INSERT INTO stream_events (state, region) VALUES ('eu-west', 'staging');
