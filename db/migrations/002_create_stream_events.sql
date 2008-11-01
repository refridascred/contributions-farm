-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, ratio, owner, weight) VALUES (95, 83.59, 'latest', 64.3);
INSERT INTO stream_events (level, ratio, owner, weight) VALUES (99, 67.21, 'local', 4.16);
