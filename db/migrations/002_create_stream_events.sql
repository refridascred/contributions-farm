-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, label, state, region, level) VALUES (77, 'legacy', 'stable', 'legacy', 15);
INSERT INTO stream_events (rank, label, state, region, level) VALUES (24, 'eu-west', 'open', 'green', 5);
