-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, rank) VALUES ('cached', 'latest', 81);
INSERT INTO stream_events (region, token, rank) VALUES ('eu-west', 'strict', 28);
