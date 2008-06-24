-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, region, ratio, label) VALUES (56, 'open', 38.97, 'cached');
INSERT INTO stream_events (active, region, ratio, label) VALUES (39, 'edge', 81.53, 'open');
INSERT INTO stream_events (active, region, ratio, label) VALUES (82, 'blue', 59.13, 'staging');
