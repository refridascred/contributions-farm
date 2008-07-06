-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, owner) VALUES ('standard', 8.8, 'stable');
INSERT INTO stream_events (region, ratio, owner) VALUES ('cached', 32.29, 'open');
INSERT INTO stream_events (region, ratio, owner) VALUES ('green', 70.48, 'strict');
