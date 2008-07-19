-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active, rank) VALUES ('legacy', 19, 75);
INSERT INTO stream_events (token, active, rank) VALUES ('eu-west', 93, 80);
INSERT INTO stream_events (token, active, rank) VALUES ('green', 19, 27);
