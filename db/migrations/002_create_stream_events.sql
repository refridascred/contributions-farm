-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, region, ratio, level) VALUES ('eu-west', 'local', 'green', 76.09, 0);
INSERT INTO stream_events (label, token, region, ratio, level) VALUES ('strict', 'green', 'local', 31.94, 43);
