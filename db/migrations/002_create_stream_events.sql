-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, weight) VALUES ('edge', 'standard', 27.12);
INSERT INTO stream_events (owner, region, weight) VALUES ('legacy', 'blue', 62.0);
