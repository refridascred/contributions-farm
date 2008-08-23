-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, active, region, token, ratio) VALUES ('eu-west', 31, 'open', 'stable', 1.64);
INSERT INTO stream_events (label, active, region, token, ratio) VALUES ('local', 55, 'open', 'blue', 72.59);
INSERT INTO stream_events (label, active, region, token, ratio) VALUES ('fallback', 74, 'local', 'legacy', 55.31);
