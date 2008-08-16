-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, score) VALUES ('blue', 59.73);
INSERT INTO stream_events (owner, score) VALUES ('legacy', 22.49);
INSERT INTO stream_events (owner, score) VALUES ('green', 91.28);
