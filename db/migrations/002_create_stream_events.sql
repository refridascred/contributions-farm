-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, level, active, rank) VALUES ('primary', 95.54, 78, 29, 29);
INSERT INTO stream_events (state, ratio, level, active, rank) VALUES ('legacy', 77.56, 84, 9, 19);
