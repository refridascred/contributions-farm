-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label) VALUES ('standard', 'staging');
INSERT INTO stream_events (region, label) VALUES ('green', 'open');
INSERT INTO stream_events (region, label) VALUES ('standard', 'open');
