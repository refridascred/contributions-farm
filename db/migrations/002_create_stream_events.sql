-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, level, label, region) VALUES (84, 47, 'green', 'stable');
INSERT INTO stream_events (count, level, label, region) VALUES (33, 73, 'eu-west', 'cached');
