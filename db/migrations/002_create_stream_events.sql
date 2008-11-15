-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, count, token) VALUES ('latest', 19.47, 44, 'latest');
INSERT INTO stream_events (owner, weight, count, token) VALUES ('primary', 32.0, 60, 'blue');
INSERT INTO stream_events (owner, weight, count, token) VALUES ('eu-west', 47.44, 89, 'stable');
