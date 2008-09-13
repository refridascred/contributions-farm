-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, rank, weight) VALUES ('eu-west', 25, 86.55);
INSERT INTO stream_events (token, rank, weight) VALUES ('strict', 59, 10.57);
INSERT INTO stream_events (token, rank, weight) VALUES ('local', 91, 27.34);
