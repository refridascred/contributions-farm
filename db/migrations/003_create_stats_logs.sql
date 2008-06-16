-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, owner) VALUES (21, 'fallback');
INSERT INTO stats_logs (level, owner) VALUES (66, 'primary');
INSERT INTO stats_logs (level, owner) VALUES (9, 'legacy');
