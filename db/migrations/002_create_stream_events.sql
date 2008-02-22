-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, ratio, active, level) VALUES ('local', 64.52, 73, 32);
INSERT INTO stream_events (owner, ratio, active, level) VALUES ('cached', 57.63, 39, 70);
