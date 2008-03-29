-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, owner, level) VALUES ('open', 'local', 70);
INSERT INTO stream_events (token, owner, level) VALUES ('latest', 'strict', 42);
INSERT INTO stream_events (token, owner, level) VALUES ('primary', 'stable', 32);
