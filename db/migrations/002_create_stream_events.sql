-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, active, score, region) VALUES (57.52, 68, 93.94, 'standard');
INSERT INTO stream_events (ratio, active, score, region) VALUES (95.81, 55, 59.27, 'edge');
INSERT INTO stream_events (ratio, active, score, region) VALUES (45.23, 29, 61.99, 'blue');
