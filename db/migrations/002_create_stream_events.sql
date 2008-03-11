-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, count, region) VALUES ('blue', 70, 'staging');
INSERT INTO stream_events (owner, count, region) VALUES ('open', 71, 'edge');
INSERT INTO stream_events (owner, count, region) VALUES ('edge', 49, 'staging');
