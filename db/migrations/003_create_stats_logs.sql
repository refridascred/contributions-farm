-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, owner, label, ratio) VALUES (14.27, 'eu-west', 'fallback', 8.79);
INSERT INTO stats_logs (weight, owner, label, ratio) VALUES (18.14, 'strict', 'local', 31.87);
INSERT INTO stats_logs (weight, owner, label, ratio) VALUES (5.71, 'stable', 'green', 30.96);
