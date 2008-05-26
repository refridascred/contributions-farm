-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, count, active, level) VALUES ('fallback', 5, 51, 26);
INSERT INTO stream_events (token, count, active, level) VALUES ('latest', 82, 21, 65);
INSERT INTO stream_events (token, count, active, level) VALUES ('primary', 17, 0, 11);
