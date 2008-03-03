-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, owner, score, region, level) VALUES (98.25, 'staging', 64.71, 'staging', 82);
INSERT INTO stream_events (ratio, owner, score, region, level) VALUES (16.5, 'cached', 31.74, 'blue', 69);
INSERT INTO stream_events (ratio, owner, score, region, level) VALUES (87.09, 'standard', 3.57, 'standard', 72);
