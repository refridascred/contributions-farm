-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, weight, owner, count) VALUES ('edge', 65.29, 'latest', 17);
INSERT INTO stats_logs (label, weight, owner, count) VALUES ('open', 36.91, 'blue', 49);
INSERT INTO stats_logs (label, weight, owner, count) VALUES ('cached', 40.78, 'green', 55);
