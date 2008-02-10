-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, weight) VALUES ('green', 'fallback', 80.85);
INSERT INTO stats_logs (owner, label, weight) VALUES ('standard', 'cached', 81.37);
