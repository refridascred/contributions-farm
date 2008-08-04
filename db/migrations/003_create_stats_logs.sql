-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, region, state, weight, ratio) VALUES ('primary', 'fallback', 'staging', 20.14, 96.28);
INSERT INTO stats_logs (owner, region, state, weight, ratio) VALUES ('latest', 'fallback', 'cached', 70.39, 6.3);
