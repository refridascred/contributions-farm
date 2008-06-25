-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, ratio, state, count) VALUES ('blue', 95.13, 'fallback', 84);
INSERT INTO stats_logs (label, ratio, state, count) VALUES ('eu-west', 19.08, 'eu-west', 19);
