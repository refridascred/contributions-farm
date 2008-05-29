-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level, token) VALUES ('staging', 10, 'blue');
INSERT INTO stream_events (owner, level, token) VALUES ('edge', 55, 'standard');
INSERT INTO stream_events (owner, level, token) VALUES ('eu-west', 83, 'legacy');
