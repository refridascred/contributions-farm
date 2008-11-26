-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, region) VALUES (43.24, 86.84, 'green');
INSERT INTO stream_events (ratio, score, region) VALUES (64.33, 29.87, 'cached');
INSERT INTO stream_events (ratio, score, region) VALUES (95.29, 19.34, 'primary');
