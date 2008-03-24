-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, ratio, level, region) VALUES ('strict', 'latest', 61.71, 51, 'primary');
INSERT INTO stream_events (token, label, ratio, level, region) VALUES ('primary', 'cached', 13.94, 68, 'standard');
INSERT INTO stream_events (token, label, ratio, level, region) VALUES ('green', 'primary', 10.61, 35, 'local');
