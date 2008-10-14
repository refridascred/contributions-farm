-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, weight, region, ratio) VALUES ('stable', 42.88, 'local', 16.09);
INSERT INTO stream_events (owner, weight, region, ratio) VALUES ('eu-west', 58.42, 'edge', 36.77);
INSERT INTO stream_events (owner, weight, region, ratio) VALUES ('eu-west', 34.73, 'green', 93.61);
