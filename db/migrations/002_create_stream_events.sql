-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count, token, active) VALUES (5, 81, 'standard', 31);
INSERT INTO stream_events (level, count, token, active) VALUES (27, 88, 'latest', 20);
INSERT INTO stream_events (level, count, token, active) VALUES (35, 82, 'blue', 1);
