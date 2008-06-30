-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, level, count, ratio, weight) VALUES ('local', 73, 76, 48.43, 86.33);
INSERT INTO stream_events (owner, level, count, ratio, weight) VALUES ('staging', 30, 99, 63.0, 38.78);
