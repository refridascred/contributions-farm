-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, ratio) VALUES ('stable', 'staging', 86.44);
INSERT INTO stream_events (region, owner, ratio) VALUES ('staging', 'blue', 54.43);
INSERT INTO stream_events (region, owner, ratio) VALUES ('primary', 'latest', 39.61);
