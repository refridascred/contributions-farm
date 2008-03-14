-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, state) VALUES ('staging', 'blue');
INSERT INTO stream_events (token, state) VALUES ('latest', 'green');
INSERT INTO stream_events (token, state) VALUES ('local', 'blue');
