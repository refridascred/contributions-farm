-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, region, active) VALUES ('latest', 'strict', 89);
INSERT INTO stream_events (state, region, active) VALUES ('green', 'local', 43);
INSERT INTO stream_events (state, region, active) VALUES ('staging', 'primary', 95);
