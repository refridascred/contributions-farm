-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, token, owner) VALUES ('cached', 'fallback', 'blue');
INSERT INTO stream_events (region, token, owner) VALUES ('eu-west', 'latest', 'cached');
INSERT INTO stream_events (region, token, owner) VALUES ('green', 'legacy', 'legacy');
