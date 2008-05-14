-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, count, ratio, active, token) VALUES ('cached', 15, 59.67, 49, 'latest');
INSERT INTO stream_events (region, count, ratio, active, token) VALUES ('eu-west', 23, 85.77, 94, 'local');
