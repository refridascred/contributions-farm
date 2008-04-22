-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, rank, owner) VALUES ('blue', 0, 'open');
INSERT INTO stream_events (label, rank, owner) VALUES ('local', 14, 'legacy');
INSERT INTO stream_events (label, rank, owner) VALUES ('cached', 6, 'standard');
