-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, weight, level, ratio, state) VALUES ('green', 45.34, 4, 68.28, 'cached');
INSERT INTO stream_events (owner, weight, level, ratio, state) VALUES ('edge', 59.91, 50, 8.58, 'latest');
