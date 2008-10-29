-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, token, rank, ratio) VALUES ('blue', 'strict', 91, 4.52);
INSERT INTO stream_events (label, token, rank, ratio) VALUES ('edge', 'green', 10, 55.89);
