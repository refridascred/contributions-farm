-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, label, count) VALUES (63, 'legacy', 22);
INSERT INTO stats_logs (level, label, count) VALUES (70, 'eu-west', 93);
INSERT INTO stats_logs (level, label, count) VALUES (51, 'open', 26);
