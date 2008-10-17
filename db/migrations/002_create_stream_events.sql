-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, token) VALUES ('standard', 67.28, 'strict');
INSERT INTO stream_events (label, ratio, token) VALUES ('legacy', 7.93, 'cached');
INSERT INTO stream_events (label, ratio, token) VALUES ('local', 42.85, 'latest');
