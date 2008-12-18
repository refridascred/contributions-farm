-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, level, label) VALUES ('blue', 59, 'blue');
INSERT INTO stream_events (token, level, label) VALUES ('local', 51, 'standard');
INSERT INTO stream_events (token, level, label) VALUES ('latest', 45, 'strict');
