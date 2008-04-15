-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, level) VALUES ('fallback', 13);
INSERT INTO stream_events (token, level) VALUES ('edge', 21);
INSERT INTO stream_events (token, level) VALUES ('edge', 17);
