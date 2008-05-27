-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, owner, active, region, level) VALUES ('primary', 'green', 1, 'local', 4);
INSERT INTO stream_events (token, owner, active, region, level) VALUES ('legacy', 'green', 60, 'open', 60);
