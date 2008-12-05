-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, level) VALUES (0, 'open', 25);
INSERT INTO stream_events (rank, token, level) VALUES (76, 'staging', 99);
INSERT INTO stream_events (rank, token, level) VALUES (49, 'standard', 9);
