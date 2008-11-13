-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, token) VALUES ('cached', 85.12, 'cached');
INSERT INTO stream_events (label, ratio, token) VALUES ('local', 52.38, 'stable');
INSERT INTO stream_events (label, ratio, token) VALUES ('standard', 31.09, 'local');
