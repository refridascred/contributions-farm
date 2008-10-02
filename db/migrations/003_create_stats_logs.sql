-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, label, ratio) VALUES (89, 'staging', 32.06);
INSERT INTO stats_logs (count, label, ratio) VALUES (59, 'cached', 81.69);
INSERT INTO stats_logs (count, label, ratio) VALUES (19, 'local', 95.24);
