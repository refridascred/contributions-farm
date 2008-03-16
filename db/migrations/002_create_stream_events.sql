-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, region, label, level) VALUES (22, 'blue', 'edge', 29);
INSERT INTO stream_events (active, region, label, level) VALUES (18, 'standard', 'edge', 5);
INSERT INTO stream_events (active, region, label, level) VALUES (87, 'primary', 'blue', 73);
