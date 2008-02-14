-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, active, region) VALUES (8, 35, 'standard');
INSERT INTO stream_events (count, active, region) VALUES (76, 88, 'latest');
INSERT INTO stream_events (count, active, region) VALUES (1, 55, 'blue');
