-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, active, level) VALUES (72.75, 'stable', 90, 74);
INSERT INTO stream_events (ratio, owner, active, level) VALUES (80.95, 'fallback', 8, 66);
INSERT INTO stream_events (ratio, owner, active, level) VALUES (81.33, 'open', 16, 79);
