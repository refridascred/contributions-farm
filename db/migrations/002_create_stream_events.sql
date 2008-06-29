-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, ratio, level, rank) VALUES ('staging', 56.34, 94, 47);
INSERT INTO stream_events (region, ratio, level, rank) VALUES ('stable', 30.36, 65, 62);
INSERT INTO stream_events (region, ratio, level, rank) VALUES ('latest', 11.53, 47, 19);
