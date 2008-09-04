-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, active, weight) VALUES ('legacy', 'local', 1, 15.91);
INSERT INTO stream_events (region, owner, active, weight) VALUES ('edge', 'latest', 12, 92.32);
INSERT INTO stream_events (region, owner, active, weight) VALUES ('eu-west', 'eu-west', 94, 48.23);
