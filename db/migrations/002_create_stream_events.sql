-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, count, region, level, label) VALUES (6.55, 12, 'staging', 90, 'legacy');
INSERT INTO stream_events (score, count, region, level, label) VALUES (87.82, 63, 'cached', 12, 'primary');
INSERT INTO stream_events (score, count, region, level, label) VALUES (46.36, 3, 'latest', 19, 'latest');
