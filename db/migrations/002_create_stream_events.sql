-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, owner, label) VALUES ('stable', 'edge', 'primary', 'latest');
INSERT INTO stream_events (region, token, owner, label) VALUES ('legacy', 'fallback', 'eu-west', 'blue');
INSERT INTO stream_events (region, token, owner, label) VALUES ('green', 'blue', 'legacy', 'edge');
