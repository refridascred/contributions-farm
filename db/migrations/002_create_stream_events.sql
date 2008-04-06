-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, state, region, rank, owner) VALUES ('legacy', 'eu-west', 'standard', 59, 'latest');
INSERT INTO stream_events (token, state, region, rank, owner) VALUES ('eu-west', 'edge', 'primary', 77, 'blue');
