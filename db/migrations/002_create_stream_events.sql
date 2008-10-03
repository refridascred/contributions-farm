-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, level, owner) VALUES ('staging', 14.69, 20, 'fallback');
INSERT INTO stream_events (region, ratio, level, owner) VALUES ('latest', 83.19, 74, 'latest');
INSERT INTO stream_events (region, ratio, level, owner) VALUES ('latest', 71.39, 79, 'staging');
