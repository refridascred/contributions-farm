-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, weight, active, level, rank) VALUES ('eu-west', 13.19, 79, 92, 43);
INSERT INTO stats_logs (state, weight, active, level, rank) VALUES ('primary', 43.23, 62, 89, 37);
