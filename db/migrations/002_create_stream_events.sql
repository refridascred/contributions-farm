-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, rank, token, weight) VALUES ('eu-west', 18, 'edge', 68.49);
INSERT INTO stream_events (label, rank, token, weight) VALUES ('staging', 14, 'local', 78.71);
INSERT INTO stream_events (label, rank, token, weight) VALUES ('strict', 42, 'standard', 94.23);
