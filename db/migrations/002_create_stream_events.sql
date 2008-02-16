-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, label, token, ratio, region) VALUES (81, 'open', 'cached', 93.57, 'cached');
INSERT INTO stream_events (level, label, token, ratio, region) VALUES (26, 'standard', 'legacy', 4.07, 'stable');
