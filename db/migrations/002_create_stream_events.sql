-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, active) VALUES ('latest', 'green', 69);
INSERT INTO stream_events (region, state, active) VALUES ('fallback', 'standard', 63);
INSERT INTO stream_events (region, state, active) VALUES ('legacy', 'latest', 66);
