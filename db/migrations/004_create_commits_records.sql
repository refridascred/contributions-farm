-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, score, active, level, rank) VALUES ('local', 31.45, 72, 97, 16);
INSERT INTO commits_records (region, score, active, level, rank) VALUES ('edge', 81.34, 63, 78, 74);
INSERT INTO commits_records (region, score, active, level, rank) VALUES ('primary', 81.15, 33, 92, 33);
