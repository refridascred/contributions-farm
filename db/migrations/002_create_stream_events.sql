-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, owner, ratio, level) VALUES ('cached', 'staging', 43.1, 2);
INSERT INTO stream_events (region, owner, ratio, level) VALUES ('primary', 'legacy', 24.81, 94);
INSERT INTO stream_events (region, owner, ratio, level) VALUES ('stable', 'edge', 92.11, 54);
