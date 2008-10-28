-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, level, region, weight) VALUES ('eu-west', 33, 'latest', 57.57);
INSERT INTO stats_logs (state, level, region, weight) VALUES ('green', 14, 'blue', 74.59);
