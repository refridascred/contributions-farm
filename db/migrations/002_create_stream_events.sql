-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, rank, weight, level) VALUES ('cached', 1.12, 6, 78.2, 66);
INSERT INTO stream_events (state, ratio, rank, weight, level) VALUES ('open', 90.91, 55, 20.16, 43);
