-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, owner, count, region) VALUES ('standard', 'eu-west', 31, 'green');
INSERT INTO stream_events (state, owner, count, region) VALUES ('eu-west', 'legacy', 66, 'eu-west');
