-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, owner, label) VALUES ('blue', 'green', 'local');
INSERT INTO stream_events (token, owner, label) VALUES ('eu-west', 'latest', 'blue');
