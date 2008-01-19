-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, weight, level, region) VALUES (49.46, 13.36, 89, 'latest');
INSERT INTO stream_events (score, weight, level, region) VALUES (58.72, 7.47, 50, 'fallback');
INSERT INTO stream_events (score, weight, level, region) VALUES (87.94, 49.46, 2, 'open');
