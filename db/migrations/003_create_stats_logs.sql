-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, owner, ratio) VALUES ('strict', 'cached', 83.38);
INSERT INTO stats_logs (region, owner, ratio) VALUES ('stable', 'open', 30.79);
