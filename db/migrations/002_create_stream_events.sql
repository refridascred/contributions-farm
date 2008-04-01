-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, weight, ratio, token) VALUES ('eu-west', 7.85, 86.34, 'stable');
INSERT INTO stream_events (region, weight, ratio, token) VALUES ('staging', 37.69, 18.51, 'cached');
INSERT INTO stream_events (region, weight, ratio, token) VALUES ('cached', 29.63, 95.71, 'open');
