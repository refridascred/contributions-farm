-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, count, weight) VALUES ('strict', 81, 71.92);
INSERT INTO stream_events (owner, count, weight) VALUES ('fallback', 6, 86.44);
INSERT INTO stream_events (owner, count, weight) VALUES ('legacy', 78, 90.54);
