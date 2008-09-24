-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, token, active) VALUES (19, 'stable', 45);
INSERT INTO stream_events (level, token, active) VALUES (4, 'blue', 36);
INSERT INTO stream_events (level, token, active) VALUES (7, 'fallback', 52);
