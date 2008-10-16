-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, region, rank) VALUES (15.1, 32, 'green', 86);
INSERT INTO stream_events (ratio, active, region, rank) VALUES (7.05, 61, 'latest', 63);
INSERT INTO stream_events (ratio, active, region, rank) VALUES (66.14, 58, 'blue', 87);
