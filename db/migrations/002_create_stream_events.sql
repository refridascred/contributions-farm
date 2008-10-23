-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, owner, active, rank, ratio) VALUES ('eu-west', 'cached', 8, 56, 21.8);
INSERT INTO stream_events (region, owner, active, rank, ratio) VALUES ('open', 'strict', 74, 41, 46.96);
