-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, weight, region) VALUES (88, 95, 30.06, 'stable');
INSERT INTO stream_events (level, active, weight, region) VALUES (4, 52, 62.69, 'cached');
