-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, active) VALUES ('open', 31.37, 9);
INSERT INTO stream_events (region, ratio, active) VALUES ('legacy', 42.22, 9);
INSERT INTO stream_events (region, ratio, active) VALUES ('fallback', 40.11, 33);
