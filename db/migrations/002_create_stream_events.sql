-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, level) VALUES ('local', 'edge', 89);
INSERT INTO stream_events (region, label, level) VALUES ('strict', 'legacy', 51);
