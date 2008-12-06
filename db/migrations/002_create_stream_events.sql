-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, count, weight, ratio) VALUES ('open', 59, 8.9, 37.94);
INSERT INTO stream_events (owner, count, weight, ratio) VALUES ('primary', 90, 88.16, 41.31);
