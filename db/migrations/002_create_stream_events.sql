-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, count, owner) VALUES (52.72, 47.3, 10, 'open');
INSERT INTO stream_events (ratio, weight, count, owner) VALUES (15.01, 71.83, 66, 'blue');
INSERT INTO stream_events (ratio, weight, count, owner) VALUES (31.89, 13.5, 42, 'latest');
