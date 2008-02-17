-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, rank, ratio, token) VALUES ('standard', 40, 43.44, 'stable');
INSERT INTO stream_events (region, rank, ratio, token) VALUES ('blue', 55, 83.19, 'strict');
INSERT INTO stream_events (region, rank, ratio, token) VALUES ('primary', 55, 70.03, 'standard');
