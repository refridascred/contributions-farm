-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, owner, region, level) VALUES (9.46, 'staging', 'local', 26);
INSERT INTO stream_events (ratio, owner, region, level) VALUES (66.61, 'latest', 'edge', 63);
