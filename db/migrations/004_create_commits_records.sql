-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, level, owner, active, score) VALUES (66.92, 81, 'edge', 45, 85.19);
INSERT INTO commits_records (ratio, level, owner, active, score) VALUES (23.85, 37, 'local', 82, 29.97);
INSERT INTO commits_records (ratio, level, owner, active, score) VALUES (41.99, 66, 'primary', 30, 75.73);
