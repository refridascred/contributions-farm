-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, label, rank, ratio) VALUES ('latest', 'open', 'open', 12, 12.73);
INSERT INTO stats_logs (state, region, label, rank, ratio) VALUES ('latest', 'local', 'legacy', 78, 32.56);
INSERT INTO stats_logs (state, region, label, rank, ratio) VALUES ('primary', 'legacy', 'open', 55, 74.72);
