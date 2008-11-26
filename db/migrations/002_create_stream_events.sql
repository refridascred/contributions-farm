-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, owner, region) VALUES ('legacy', 'local', 'open');
INSERT INTO stream_events (state, owner, region) VALUES ('edge', 'local', 'fallback');
INSERT INTO stream_events (state, owner, region) VALUES ('strict', 'primary', 'standard');
