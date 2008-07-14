-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, count, region, rank, level) VALUES (71.17, 89, 'latest', 43, 7);
INSERT INTO stream_events (ratio, count, region, rank, level) VALUES (45.92, 61, 'latest', 67, 93);
INSERT INTO stream_events (ratio, count, region, rank, level) VALUES (21.85, 93, 'latest', 85, 28);
