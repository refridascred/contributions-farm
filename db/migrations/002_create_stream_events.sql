-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner) VALUES ('stable', 'staging');
INSERT INTO stream_events (token, owner) VALUES ('cached', 'local');
INSERT INTO stream_events (token, owner) VALUES ('fallback', 'primary');
