-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, label, rank) VALUES ('local', 'strict', 20);
INSERT INTO stream_events (token, label, rank) VALUES ('cached', 'latest', 42);
INSERT INTO stream_events (token, label, rank) VALUES ('eu-west', 'local', 71);
