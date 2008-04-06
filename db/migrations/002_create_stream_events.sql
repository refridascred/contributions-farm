-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, ratio, region) VALUES ('legacy', 87, 70.13, 'open');
INSERT INTO stream_events (state, level, ratio, region) VALUES ('green', 11, 38.28, 'green');
