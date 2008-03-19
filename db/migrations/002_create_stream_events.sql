-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, label, region) VALUES ('eu-west', 'open', 'edge');
INSERT INTO stream_events (state, label, region) VALUES ('eu-west', 'staging', 'local');
INSERT INTO stream_events (state, label, region) VALUES ('strict', 'blue', 'local');
