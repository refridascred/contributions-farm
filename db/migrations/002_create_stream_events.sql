-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, label, level, weight, ratio) VALUES ('latest', 'open', 91, 18.32, 54.57);
INSERT INTO stream_events (state, label, level, weight, ratio) VALUES ('stable', 'latest', 29, 63.65, 10.58);
