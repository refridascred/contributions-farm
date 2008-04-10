-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, active) VALUES (2, 'edge', 72);
INSERT INTO stream_events (rank, label, active) VALUES (46, 'strict', 1);
INSERT INTO stream_events (rank, label, active) VALUES (20, 'primary', 95);
