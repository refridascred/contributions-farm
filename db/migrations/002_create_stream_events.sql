-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, weight, state, owner) VALUES (81, 'edge', 24.09, 'local', 'fallback');
INSERT INTO stream_events (rank, label, weight, state, owner) VALUES (9, 'latest', 51.35, 'eu-west', 'strict');
