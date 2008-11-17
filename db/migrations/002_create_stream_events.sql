-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, active, weight, count, region) VALUES ('eu-west', 38, 61.31, 14, 'local');
INSERT INTO stream_events (state, active, weight, count, region) VALUES ('eu-west', 60, 60.21, 48, 'eu-west');
