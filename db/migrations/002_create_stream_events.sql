-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, region, level, owner, ratio) VALUES ('eu-west', 'edge', 77, 'edge', 45.66);
INSERT INTO stream_events (state, region, level, owner, ratio) VALUES ('cached', 'eu-west', 99, 'open', 21.33);
