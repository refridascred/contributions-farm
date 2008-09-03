-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, token) VALUES ('primary', 58.03, 'open');
INSERT INTO stream_events (region, ratio, token) VALUES ('stable', 26.57, 'green');
INSERT INTO stream_events (region, ratio, token) VALUES ('staging', 59.47, 'green');
