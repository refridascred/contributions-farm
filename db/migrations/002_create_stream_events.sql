-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, token, owner, ratio, rank) VALUES (67.83, 'legacy', 'staging', 80.14, 75);
INSERT INTO stream_events (weight, token, owner, ratio, rank) VALUES (75.57, 'open', 'green', 27.65, 82);
