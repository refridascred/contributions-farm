-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region, owner, rank) VALUES (43.02, 'blue', 'staging', 4);
INSERT INTO stream_events (weight, region, owner, rank) VALUES (71.61, 'staging', 'strict', 39);
INSERT INTO stream_events (weight, region, owner, rank) VALUES (60.3, 'primary', 'stable', 28);
