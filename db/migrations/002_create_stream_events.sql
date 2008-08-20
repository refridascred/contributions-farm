-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, active, rank, weight, region) VALUES (71, 40, 68, 82.33, 'strict');
INSERT INTO stream_events (count, active, rank, weight, region) VALUES (32, 37, 43, 67.76, 'edge');
INSERT INTO stream_events (count, active, rank, weight, region) VALUES (78, 35, 96, 14.48, 'primary');
