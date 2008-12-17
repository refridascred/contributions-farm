-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, ratio, token, region) VALUES ('legacy', 75.21, 'cached', 'cached');
INSERT INTO stream_events (label, ratio, token, region) VALUES ('latest', 6.2, 'staging', 'stable');
INSERT INTO stream_events (label, ratio, token, region) VALUES ('staging', 13.12, 'local', 'standard');
