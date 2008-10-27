-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, owner, active, ratio, region) VALUES (17.07, 'staging', 23, 2.54, 'open');
