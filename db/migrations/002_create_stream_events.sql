-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, state, owner, region, ratio) VALUES (31.66, 'cached', 'green', 'green', 5.01);
INSERT INTO stream_events (score, state, owner, region, ratio) VALUES (71.51, 'eu-west', 'local', 'open', 62.94);
INSERT INTO stream_events (score, state, owner, region, ratio) VALUES (90.48, 'green', 'blue', 'green', 35.32);
