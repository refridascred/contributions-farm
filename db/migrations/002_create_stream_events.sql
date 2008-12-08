-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, score, region, level) VALUES ('strict', 38.15, 'open', 43);
INSERT INTO stream_events (owner, score, region, level) VALUES ('green', 50.58, 'local', 30);
