-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, owner) VALUES ('staging', 77.34, 'cached');
INSERT INTO stream_events (region, weight, owner) VALUES ('stable', 32.29, 'edge');
INSERT INTO stream_events (region, weight, owner) VALUES ('fallback', 36.6, 'latest');
