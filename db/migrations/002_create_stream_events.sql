-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, count, level) VALUES ('strict', 37, 44);
INSERT INTO stream_events (owner, count, level) VALUES ('cached', 13, 38);
INSERT INTO stream_events (owner, count, level) VALUES ('primary', 95, 61);
