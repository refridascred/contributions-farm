-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, active, rank) VALUES ('local', 11, 54);
INSERT INTO stream_events (state, active, rank) VALUES ('latest', 77, 22);
INSERT INTO stream_events (state, active, rank) VALUES ('open', 68, 76);
