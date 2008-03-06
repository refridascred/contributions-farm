-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, count) VALUES (80, 'legacy', 56);
INSERT INTO stream_events (rank, label, count) VALUES (43, 'cached', 27);
INSERT INTO stream_events (rank, label, count) VALUES (5, 'local', 59);
