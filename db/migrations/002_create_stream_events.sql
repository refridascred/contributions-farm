-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, active, ratio, state) VALUES ('open', 75, 13.35, 'eu-west');
INSERT INTO stream_events (region, active, ratio, state) VALUES ('latest', 75, 5.46, 'blue');
INSERT INTO stream_events (region, active, ratio, state) VALUES ('primary', 88, 90.8, 'open');
