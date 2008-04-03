-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, owner, region) VALUES (20.24, 'latest', 'strict');
INSERT INTO stream_events (ratio, owner, region) VALUES (3.45, 'standard', 'legacy');
