-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, owner, weight, region) VALUES (78, 'standard', 54.24, 'primary');
INSERT INTO stream_events (count, owner, weight, region) VALUES (60, 'latest', 78.02, 'fallback');
