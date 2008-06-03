-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, level, active, count, region) VALUES ('cached', 75, 62, 62, 'open');
INSERT INTO stream_events (label, level, active, count, region) VALUES ('open', 5, 64, 21, 'strict');
INSERT INTO stream_events (label, level, active, count, region) VALUES ('local', 14, 22, 87, 'cached');
