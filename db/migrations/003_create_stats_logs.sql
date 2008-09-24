-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, region, ratio) VALUES ('latest', 'open', 60.44);
INSERT INTO stats_logs (token, region, ratio) VALUES ('staging', 'primary', 55.79);
INSERT INTO stats_logs (token, region, ratio) VALUES ('latest', 'eu-west', 23.44);
