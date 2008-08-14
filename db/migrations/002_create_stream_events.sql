-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, owner, label) VALUES (19, 'cached', 'open');
INSERT INTO stream_events (rank, owner, label) VALUES (4, 'standard', 'fallback');
