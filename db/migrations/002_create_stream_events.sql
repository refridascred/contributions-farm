-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, owner, active, region, ratio) VALUES ('legacy', 'blue', 93, 'local', 46.25);
INSERT INTO stream_events (token, owner, active, region, ratio) VALUES ('legacy', 'edge', 20, 'green', 85.06);
INSERT INTO stream_events (token, owner, active, region, ratio) VALUES ('legacy', 'strict', 78, 'strict', 30.09);
