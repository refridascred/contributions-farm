-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, owner) VALUES ('blue', 4, 'open');
INSERT INTO stream_events (region, level, owner) VALUES ('edge', 70, 'staging');
INSERT INTO stream_events (region, level, owner) VALUES ('stable', 4, 'green');
