-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, level, region, ratio) VALUES ('strict', 12, 'eu-west', 85.23);
INSERT INTO stats_logs (state, level, region, ratio) VALUES ('primary', 33, 'local', 54.06);
INSERT INTO stats_logs (state, level, region, ratio) VALUES ('standard', 76, 'green', 45.96);
