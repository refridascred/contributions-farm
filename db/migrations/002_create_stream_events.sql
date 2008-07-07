-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, ratio, owner) VALUES ('green', 82, 12.54, 'primary');
INSERT INTO stream_events (region, level, ratio, owner) VALUES ('blue', 26, 72.88, 'fallback');
INSERT INTO stream_events (region, level, ratio, owner) VALUES ('eu-west', 20, 67.88, 'staging');
