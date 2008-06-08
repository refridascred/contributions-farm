-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, token, region, count) VALUES ('strict', 'eu-west', 'strict', 41);
INSERT INTO stats_logs (label, token, region, count) VALUES ('open', 'latest', 'standard', 97);
