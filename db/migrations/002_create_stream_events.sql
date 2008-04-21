-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, ratio, state, active) VALUES ('staging', 82.27, 'green', 88);
INSERT INTO stream_events (region, ratio, state, active) VALUES ('green', 56.39, 'staging', 2);
INSERT INTO stream_events (region, ratio, state, active) VALUES ('green', 77.84, 'latest', 54);
