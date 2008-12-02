-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, region, label) VALUES (21, 'primary', 'eu-west', 'staging');
INSERT INTO stream_events (rank, state, region, label) VALUES (26, 'primary', 'cached', 'latest');
