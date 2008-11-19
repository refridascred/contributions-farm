-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, rank, active, state) VALUES ('eu-west', 67.14, 48, 16, 'stable');
INSERT INTO stats_logs (region, weight, rank, active, state) VALUES ('cached', 44.4, 44, 19, 'legacy');
