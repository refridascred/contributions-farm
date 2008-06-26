-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, owner, score) VALUES ('edge', 59.3, 'latest', 92.29);
INSERT INTO stream_events (region, ratio, owner, score) VALUES ('cached', 12.98, 'strict', 13.93);
