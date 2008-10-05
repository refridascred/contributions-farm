-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, label, token, level) VALUES ('eu-west', 'eu-west', 'fallback', 'strict', 35);
INSERT INTO stream_events (region, owner, label, token, level) VALUES ('staging', 'cached', 'staging', 'fallback', 24);
