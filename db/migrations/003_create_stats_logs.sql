-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, count, state, ratio) VALUES ('open', 41, 'fallback', 64.91);
INSERT INTO stats_logs (region, count, state, ratio) VALUES ('primary', 92, 'green', 0.09);
INSERT INTO stats_logs (region, count, state, ratio) VALUES ('strict', 96, 'local', 37.52);
