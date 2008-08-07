-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, weight, level) VALUES ('eu-west', 5.63, 47);
INSERT INTO stats_logs (token, weight, level) VALUES ('local', 47.54, 13);
INSERT INTO stats_logs (token, weight, level) VALUES ('local', 4.52, 43);
