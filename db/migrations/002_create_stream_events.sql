-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, label, ratio, active, region) VALUES (0, 'legacy', 16.65, 82, 'strict');
INSERT INTO stream_events (level, label, ratio, active, region) VALUES (88, 'eu-west', 94.27, 59, 'local');
INSERT INTO stream_events (level, label, ratio, active, region) VALUES (86, 'blue', 66.27, 16, 'eu-west');
