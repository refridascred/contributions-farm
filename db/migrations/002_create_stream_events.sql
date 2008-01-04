-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, label, ratio, count) VALUES ('latest', 'latest', 86.07, 60);
INSERT INTO stream_events (token, label, ratio, count) VALUES ('edge', 'local', 37.63, 41);
