-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, label, region) VALUES ('primary', 'fallback', 'cached');
INSERT INTO stream_events (owner, label, region) VALUES ('strict', 'strict', 'primary');
INSERT INTO stream_events (owner, label, region) VALUES ('latest', 'strict', 'staging');
