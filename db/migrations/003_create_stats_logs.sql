-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, token, ratio) VALUES (35.1, 'latest', 11.91);
INSERT INTO stats_logs (weight, token, ratio) VALUES (76.62, 'latest', 25.69);
INSERT INTO stats_logs (weight, token, ratio) VALUES (52.65, 'strict', 90.36);
