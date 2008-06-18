-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, region, rank) VALUES (58.68, 'fallback', 59);
INSERT INTO stream_events (ratio, region, rank) VALUES (19.51, 'strict', 66);
