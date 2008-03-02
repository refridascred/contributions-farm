-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, count, active, region) VALUES ('latest', 23, 23, 'open');
INSERT INTO stream_events (owner, count, active, region) VALUES ('local', 73, 6, 'latest');
INSERT INTO stream_events (owner, count, active, region) VALUES ('primary', 77, 38, 'strict');
