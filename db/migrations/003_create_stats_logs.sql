-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, token, count) VALUES ('open', 'latest', 54);
INSERT INTO stats_logs (region, token, count) VALUES ('standard', 'strict', 22);
INSERT INTO stats_logs (region, token, count) VALUES ('eu-west', 'green', 7);
