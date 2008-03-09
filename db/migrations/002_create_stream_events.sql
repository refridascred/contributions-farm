-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, region, count) VALUES (55, 'edge', 'cached', 67);
INSERT INTO stream_events (level, label, region, count) VALUES (26, 'eu-west', 'fallback', 0);
INSERT INTO stream_events (level, label, region, count) VALUES (50, 'stable', 'local', 37);
