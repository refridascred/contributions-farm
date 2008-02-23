-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, state, label, region) VALUES (92, 'edge', 'cached', 'strict');
INSERT INTO stream_events (rank, state, label, region) VALUES (33, 'eu-west', 'legacy', 'edge');
INSERT INTO stream_events (rank, state, label, region) VALUES (13, 'standard', 'latest', 'primary');
