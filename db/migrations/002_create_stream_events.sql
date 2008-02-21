-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, state) VALUES (73.32, 99, 'primary');
INSERT INTO stream_events (ratio, active, state) VALUES (16.76, 37, 'stable');
INSERT INTO stream_events (ratio, active, state) VALUES (37.87, 38, 'primary');
