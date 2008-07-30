-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, rank, state) VALUES ('green', 'legacy', 7, 'cached');
INSERT INTO stream_events (region, owner, rank, state) VALUES ('eu-west', 'green', 84, 'latest');
