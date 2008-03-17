-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, rank, weight) VALUES ('blue', 47, 85, 40.44);
INSERT INTO stats_logs (label, active, rank, weight) VALUES ('eu-west', 44, 14, 78.41);
