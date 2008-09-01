-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level, weight) VALUES ('strict', 22, 49.52);
INSERT INTO stream_events (owner, level, weight) VALUES ('blue', 75, 37.28);
INSERT INTO stream_events (owner, level, weight) VALUES ('eu-west', 78, 47.37);
