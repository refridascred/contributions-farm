-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, active, label, count) VALUES ('local', 23, 83, 'cached', 91);
INSERT INTO stream_events (region, level, active, label, count) VALUES ('legacy', 45, 89, 'primary', 52);
INSERT INTO stream_events (region, level, active, label, count) VALUES ('open', 80, 34, 'staging', 98);
