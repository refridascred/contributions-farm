-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, ratio) VALUES (99, 64.52);
INSERT INTO stream_events (rank, ratio) VALUES (79, 52.37);
INSERT INTO stream_events (rank, ratio) VALUES (23, 67.62);
