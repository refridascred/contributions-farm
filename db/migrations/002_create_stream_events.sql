-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, owner, rank, active) VALUES ('strict', 'eu-west', 'latest', 18, 45);
INSERT INTO stream_events (token, region, owner, rank, active) VALUES ('blue', 'blue', 'latest', 43, 51);
INSERT INTO stream_events (token, region, owner, rank, active) VALUES ('stable', 'primary', 'latest', 73, 6);
