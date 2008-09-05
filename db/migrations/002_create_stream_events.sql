-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, active, count, rank) VALUES ('eu-west', 'staging', 64, 93, 45);
INSERT INTO stream_events (region, state, active, count, rank) VALUES ('blue', 'strict', 23, 21, 51);
INSERT INTO stream_events (region, state, active, count, rank) VALUES ('legacy', 'standard', 87, 94, 16);
