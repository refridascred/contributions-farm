-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, token, count, ratio, region) VALUES (73, 'cached', 25, 56.09, 'cached');
INSERT INTO stream_events (active, token, count, ratio, region) VALUES (28, 'local', 68, 26.51, 'open');
INSERT INTO stream_events (active, token, count, ratio, region) VALUES (44, 'cached', 26, 81.8, 'primary');
