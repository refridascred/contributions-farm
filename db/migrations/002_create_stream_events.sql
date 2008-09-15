-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, rank) VALUES (62, 'edge', 54);
INSERT INTO stream_events (active, token, rank) VALUES (95, 'local', 84);
INSERT INTO stream_events (active, token, rank) VALUES (11, 'standard', 80);
