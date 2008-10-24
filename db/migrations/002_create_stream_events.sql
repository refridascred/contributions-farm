-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, active, level, score) VALUES ('fallback', 85, 87, 75.29);
INSERT INTO stream_events (region, active, level, score) VALUES ('legacy', 0, 12, 30.94);
INSERT INTO stream_events (region, active, level, score) VALUES ('latest', 24, 40, 15.42);
