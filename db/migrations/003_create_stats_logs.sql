-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, count) VALUES ('strict', 'legacy', 97);
INSERT INTO stats_logs (token, region, count) VALUES ('latest', 'primary', 64);
INSERT INTO stats_logs (token, region, count) VALUES ('legacy', 'blue', 73);
