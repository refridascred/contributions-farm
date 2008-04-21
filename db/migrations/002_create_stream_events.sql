-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, token) VALUES (50.46, 95, 'staging');
INSERT INTO stream_events (ratio, active, token) VALUES (60.21, 29, 'edge');
INSERT INTO stream_events (ratio, active, token) VALUES (11.82, 40, 'cached');
