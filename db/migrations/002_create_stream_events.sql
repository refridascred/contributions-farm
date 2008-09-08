-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, active, token, region) VALUES (95.96, 79, 'stable', 'fallback');
INSERT INTO stream_events (weight, active, token, region) VALUES (24.24, 42, 'primary', 'standard');
INSERT INTO stream_events (weight, active, token, region) VALUES (31.13, 87, 'legacy', 'cached');
