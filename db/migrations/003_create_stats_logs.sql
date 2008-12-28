-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, owner, weight) VALUES ('green', 'local', 59.79);
INSERT INTO stats_logs (token, owner, weight) VALUES ('local', 'fallback', 45.34);
INSERT INTO stats_logs (token, owner, weight) VALUES ('green', 'strict', 94.91);
