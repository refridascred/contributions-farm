-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, level, weight, active) VALUES (25, 48, 9.5, 69);
INSERT INTO stream_events (rank, level, weight, active) VALUES (60, 69, 57.9, 49);
INSERT INTO stream_events (rank, level, weight, active) VALUES (63, 2, 45.53, 63);
