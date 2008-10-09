-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, token) VALUES (67.25, 15.58, 'local');
INSERT INTO stream_events (score, ratio, token) VALUES (20.9, 5.42, 'local');
INSERT INTO stream_events (score, ratio, token) VALUES (32.68, 46.77, 'cached');
