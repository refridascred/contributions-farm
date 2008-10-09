-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, level, owner) VALUES ('latest', 95, 'blue');
INSERT INTO stream_events (token, level, owner) VALUES ('stable', 52, 'fallback');
INSERT INTO stream_events (token, level, owner) VALUES ('green', 26, 'stable');
