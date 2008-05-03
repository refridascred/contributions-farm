-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, owner, rank) VALUES ('primary', 'strict', 'local', 59);
INSERT INTO stats_logs (token, region, owner, rank) VALUES ('edge', 'standard', 'blue', 91);
INSERT INTO stats_logs (token, region, owner, rank) VALUES ('legacy', 'fallback', 'blue', 84);
