-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, weight, rank, score) VALUES ('stable', 38.54, 24, 53.46);
INSERT INTO stream_events (region, weight, rank, score) VALUES ('open', 93.2, 27, 33.73);
INSERT INTO stream_events (region, weight, rank, score) VALUES ('open', 91.39, 28, 37.43);
