-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, token, ratio, level) VALUES (4, 'staging', 27.73, 31);
INSERT INTO stream_events (active, token, ratio, level) VALUES (27, 'legacy', 47.23, 35);
INSERT INTO stream_events (active, token, ratio, level) VALUES (98, 'stable', 5.45, 17);
