-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, region) VALUES (96, 87, 'cached');
INSERT INTO stream_events (level, active, region) VALUES (35, 76, 'primary');
INSERT INTO stream_events (level, active, region) VALUES (62, 94, 'stable');
