-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, active, owner, ratio) VALUES ('blue', 2, 'standard', 66.14);
INSERT INTO stats_logs (region, active, owner, ratio) VALUES ('fallback', 90, 'primary', 57.82);
