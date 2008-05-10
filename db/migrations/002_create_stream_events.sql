-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, region, weight, ratio, level) VALUES ('standard', 'eu-west', 40.02, 62.93, 57);
INSERT INTO stream_events (owner, region, weight, ratio, level) VALUES ('edge', 'standard', 1.88, 19.17, 52);
