-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, owner) VALUES ('cached', 'staging', 'blue');
INSERT INTO stream_events (token, region, owner) VALUES ('legacy', 'latest', 'primary');
