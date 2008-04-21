-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, state, region) VALUES ('local', 88, 'edge', 'edge');
INSERT INTO stream_events (label, rank, state, region) VALUES ('latest', 83, 'open', 'standard');
INSERT INTO stream_events (label, rank, state, region) VALUES ('latest', 47, 'green', 'eu-west');
