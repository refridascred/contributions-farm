-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, region, active, count) VALUES ('staging', 32.48, 'staging', 51, 36);
INSERT INTO stream_events (label, ratio, region, active, count) VALUES ('open', 75.04, 'latest', 43, 92);
INSERT INTO stream_events (label, ratio, region, active, count) VALUES ('open', 9.74, 'standard', 3, 73);
