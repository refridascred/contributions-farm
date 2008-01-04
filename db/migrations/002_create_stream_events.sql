-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, count, level, weight) VALUES ('staging', 46, 45, 81.39);
INSERT INTO stream_events (owner, count, level, weight) VALUES ('strict', 86, 4, 12.89);
INSERT INTO stream_events (owner, count, level, weight) VALUES ('cached', 37, 33, 44.36);
