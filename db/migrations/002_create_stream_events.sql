-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, region, ratio) VALUES (70.52, 'standard', 92.6);
INSERT INTO stream_events (score, region, ratio) VALUES (67.18, 'standard', 66.67);
INSERT INTO stream_events (score, region, ratio) VALUES (69.32, 'blue', 25.84);
