-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, rank, state, level) VALUES ('standard', 42, 'eu-west', 62);
INSERT INTO stream_events (region, rank, state, level) VALUES ('staging', 38, 'local', 12);
