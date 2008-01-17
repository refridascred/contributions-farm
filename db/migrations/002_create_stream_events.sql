-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, state) VALUES (86, 'open', 'open');
INSERT INTO stream_events (rank, label, state) VALUES (2, 'open', 'primary');
INSERT INTO stream_events (rank, label, state) VALUES (45, 'green', 'local');
