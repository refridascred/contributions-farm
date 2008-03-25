-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, active, region, level) VALUES (37, 'local', 80, 'fallback', 46);
INSERT INTO stream_events (count, label, active, region, level) VALUES (9, 'edge', 4, 'eu-west', 57);
INSERT INTO stream_events (count, label, active, region, level) VALUES (37, 'standard', 2, 'fallback', 27);
