-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state) VALUES ('primary', 'latest');
INSERT INTO stream_events (token, state) VALUES ('staging', 'open');
INSERT INTO stream_events (token, state) VALUES ('stable', 'eu-west');
