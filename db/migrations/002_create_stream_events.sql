-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, level, state, weight, rank) VALUES ('open', 14, 'open', 95.4, 40);
