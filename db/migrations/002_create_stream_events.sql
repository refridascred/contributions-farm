-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, state, level, active) VALUES ('cached', 'fallback', 'standard', 6, 35);
INSERT INTO stream_events (region, owner, state, level, active) VALUES ('staging', 'fallback', 'strict', 79, 55);
