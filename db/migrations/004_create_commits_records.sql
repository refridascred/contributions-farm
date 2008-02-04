-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, weight, active, level) VALUES (85, 44.67, 22, 64);
INSERT INTO commits_records (rank, weight, active, level) VALUES (4, 44.16, 26, 16);
INSERT INTO commits_records (rank, weight, active, level) VALUES (4, 48.66, 86, 53);
