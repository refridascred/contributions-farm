-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, rank, token) VALUES (40, 65, 'green');
INSERT INTO stream_events (active, rank, token) VALUES (73, 50, 'local');
INSERT INTO stream_events (active, rank, token) VALUES (39, 51, 'primary');
