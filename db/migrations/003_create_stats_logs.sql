-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, region, count) VALUES ('eu-west', 'legacy', 22);
INSERT INTO stats_logs (label, region, count) VALUES ('green', 'eu-west', 23);
INSERT INTO stats_logs (label, region, count) VALUES ('standard', 'legacy', 58);
