-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, ratio) VALUES ('stable', 'local', 5.75);
INSERT INTO stream_events (owner, region, ratio) VALUES ('stable', 'green', 53.95);
