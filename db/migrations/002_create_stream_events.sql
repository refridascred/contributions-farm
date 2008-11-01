-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, state, level) VALUES ('blue', 9.5, 'open', 8);
INSERT INTO stream_events (label, ratio, state, level) VALUES ('cached', 14.87, 'latest', 84);
