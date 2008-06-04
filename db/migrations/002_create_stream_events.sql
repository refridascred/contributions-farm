-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, state, rank) VALUES ('staging', 'latest', 'local', 88);
INSERT INTO stream_events (token, region, state, rank) VALUES ('local', 'blue', 'eu-west', 83);
INSERT INTO stream_events (token, region, state, rank) VALUES ('staging', 'blue', 'fallback', 48);
