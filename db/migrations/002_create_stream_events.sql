-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, level, count, weight, state) VALUES (51.73, 10, 81, 55.35, 'staging');
INSERT INTO stream_events (ratio, level, count, weight, state) VALUES (1.5, 12, 7, 51.2, 'latest');
