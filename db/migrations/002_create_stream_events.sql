-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, level, active) VALUES ('latest', 'primary', 78, 3);
INSERT INTO stream_events (label, region, level, active) VALUES ('edge', 'latest', 9, 54);
INSERT INTO stream_events (label, region, level, active) VALUES ('blue', 'legacy', 62, 13);
