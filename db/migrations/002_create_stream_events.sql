-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (state, owner, ratio, rank) VALUES ('strict', 'open', 60.03, 87);
INSERT INTO stream_events (state, owner, ratio, rank) VALUES ('strict', 'legacy', 63.84, 73);
