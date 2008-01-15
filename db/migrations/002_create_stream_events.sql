-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, region, active) VALUES (46.6, 'open', 'standard', 63);
INSERT INTO stream_events (score, owner, region, active) VALUES (74.42, 'staging', 'edge', 73);
INSERT INTO stream_events (score, owner, region, active) VALUES (7.19, 'eu-west', 'primary', 69);
