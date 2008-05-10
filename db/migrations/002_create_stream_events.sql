-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, ratio) VALUES ('legacy', 5.52, 30.27);
INSERT INTO stream_events (owner, weight, ratio) VALUES ('standard', 38.46, 89.17);
INSERT INTO stream_events (owner, weight, ratio) VALUES ('legacy', 67.33, 25.5);
