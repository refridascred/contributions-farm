-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, region, label) VALUES ('open', 'primary', 'fallback');
INSERT INTO stream_events (token, region, label) VALUES ('cached', 'edge', 'cached');
INSERT INTO stream_events (token, region, label) VALUES ('primary', 'open', 'eu-west');
