-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, count, weight, state) VALUES ('eu-west', 84.53, 60, 90.32, 'green');
INSERT INTO stream_events (owner, ratio, count, weight, state) VALUES ('fallback', 55.31, 93, 63.7, 'fallback');
INSERT INTO stream_events (owner, ratio, count, weight, state) VALUES ('blue', 0.89, 30, 82.75, 'strict');
