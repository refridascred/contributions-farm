-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, level) VALUES ('cached', 51);
INSERT INTO stream_events (token, level) VALUES ('stable', 56);
INSERT INTO stream_events (token, level) VALUES ('staging', 54);
