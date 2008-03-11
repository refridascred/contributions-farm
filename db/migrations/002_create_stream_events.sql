-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, weight) VALUES (90, 27.27);
INSERT INTO stream_events (rank, weight) VALUES (66, 50.95);
INSERT INTO stream_events (rank, weight) VALUES (75, 42.49);
