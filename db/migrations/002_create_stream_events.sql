-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, region, ratio, count, state) VALUES (59.26, 'local', 82.13, 20, 'local');
INSERT INTO stream_events (score, region, ratio, count, state) VALUES (50.51, 'latest', 30.6, 72, 'open');
INSERT INTO stream_events (score, region, ratio, count, state) VALUES (22.08, 'stable', 57.12, 31, 'latest');
