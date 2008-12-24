-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, count, weight, level) VALUES ('cached', 36, 94.91, 65);
INSERT INTO stream_events (owner, count, weight, level) VALUES ('local', 77, 36.3, 86);
INSERT INTO stream_events (owner, count, weight, level) VALUES ('open', 93, 32.6, 93);
