-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, weight) VALUES ('edge', 86.83);
INSERT INTO stream_events (owner, weight) VALUES ('eu-west', 92.65);
INSERT INTO stream_events (owner, weight) VALUES ('local', 13.27);
