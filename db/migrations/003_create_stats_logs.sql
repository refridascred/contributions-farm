-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, level, rank) VALUES ('legacy', 22, 43);
INSERT INTO stats_logs (label, level, rank) VALUES ('latest', 11, 8);
INSERT INTO stats_logs (label, level, rank) VALUES ('strict', 33, 84);
