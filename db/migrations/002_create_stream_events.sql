-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, weight) VALUES (98, 16, 46.9);
INSERT INTO stream_events (rank, level, weight) VALUES (46, 22, 83.57);
INSERT INTO stream_events (rank, level, weight) VALUES (68, 26, 32.63);
