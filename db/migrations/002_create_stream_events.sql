-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, region, count, label) VALUES (87, 'edge', 34, 'standard');
INSERT INTO stream_events (level, region, count, label) VALUES (88, 'blue', 33, 'primary');
INSERT INTO stream_events (level, region, count, label) VALUES (9, 'strict', 18, 'blue');
