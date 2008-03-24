-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, level, owner) VALUES ('standard', 19, 'legacy');
INSERT INTO stream_events (token, level, owner) VALUES ('fallback', 92, 'fallback');
INSERT INTO stream_events (token, level, owner) VALUES ('latest', 91, 'standard');
