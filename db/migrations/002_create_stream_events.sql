-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, token, label, rank) VALUES (30.59, 'standard', 'strict', 37);
INSERT INTO stream_events (weight, token, label, rank) VALUES (83.16, 'blue', 'eu-west', 55);
INSERT INTO stream_events (weight, token, label, rank) VALUES (33.65, 'open', 'fallback', 44);
