-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, active, token, owner) VALUES ('legacy', 80, 'stable', 'cached');
INSERT INTO stream_events (region, active, token, owner) VALUES ('edge', 99, 'green', 'edge');
INSERT INTO stream_events (region, active, token, owner) VALUES ('eu-west', 30, 'latest', 'latest');
