-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, region, label) VALUES (91, 'edge', 'latest');
INSERT INTO stream_events (active, region, label) VALUES (27, 'cached', 'eu-west');
INSERT INTO stream_events (active, region, label) VALUES (80, 'open', 'latest');
