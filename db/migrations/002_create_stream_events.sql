-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, active, weight, level) VALUES ('stable', 73, 0.37, 31);
INSERT INTO stream_events (token, active, weight, level) VALUES ('open', 1, 7.24, 93);
INSERT INTO stream_events (token, active, weight, level) VALUES ('local', 78, 24.43, 7);
