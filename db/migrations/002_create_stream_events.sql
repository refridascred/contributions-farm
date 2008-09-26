-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, owner, token, active, weight) VALUES ('blue', 'open', 'eu-west', 15, 97.7);
INSERT INTO stream_events (region, owner, token, active, weight) VALUES ('standard', 'edge', 'staging', 0, 24.67);
INSERT INTO stream_events (region, owner, token, active, weight) VALUES ('strict', 'cached', 'standard', 32, 80.26);
