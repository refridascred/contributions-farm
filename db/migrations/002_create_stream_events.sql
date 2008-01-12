-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, active, rank) VALUES ('eu-west', 88, 97);
INSERT INTO stream_events (state, active, rank) VALUES ('primary', 7, 20);
INSERT INTO stream_events (state, active, rank) VALUES ('open', 77, 33);
