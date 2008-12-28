-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level) VALUES ('eu-west', 88);
INSERT INTO stream_events (owner, level) VALUES ('blue', 48);
INSERT INTO stream_events (owner, level) VALUES ('stable', 70);
