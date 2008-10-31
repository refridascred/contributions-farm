-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level) VALUES ('stable', 77);
INSERT INTO stream_events (owner, level) VALUES ('eu-west', 76);
INSERT INTO stream_events (owner, level) VALUES ('strict', 88);
