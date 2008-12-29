-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, weight, state) VALUES ('staging', 'strict', 40.31, 'local');
INSERT INTO stream_events (region, owner, weight, state) VALUES ('cached', 'green', 58.16, 'latest');
