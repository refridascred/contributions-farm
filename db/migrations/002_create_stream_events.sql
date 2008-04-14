-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, token, region) VALUES (44, 'legacy', 'eu-west');
INSERT INTO stream_events (active, token, region) VALUES (79, 'primary', 'legacy');
INSERT INTO stream_events (active, token, region) VALUES (40, 'cached', 'standard');
