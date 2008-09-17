-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, ratio, token) VALUES ('staging', 37.1, 54.69, 'standard');
INSERT INTO stream_events (region, weight, ratio, token) VALUES ('stable', 11.57, 58.18, 'blue');
