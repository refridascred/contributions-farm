-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, ratio, region, level) VALUES (77, 1.74, 'local', 23);
INSERT INTO stream_events (active, ratio, region, level) VALUES (26, 81.1, 'eu-west', 62);
