-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, active, ratio, rank) VALUES (54.94, 97, 32.07, 84);
INSERT INTO stream_events (weight, active, ratio, rank) VALUES (94.16, 48, 94.9, 23);
INSERT INTO stream_events (weight, active, ratio, rank) VALUES (70.95, 64, 20.48, 72);
