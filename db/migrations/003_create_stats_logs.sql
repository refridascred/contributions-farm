-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, weight, owner, region, count) VALUES ('cached', 12.93, 'blue', 'fallback', 37);
INSERT INTO stats_logs (state, weight, owner, region, count) VALUES ('eu-west', 62.54, 'open', 'open', 20);
