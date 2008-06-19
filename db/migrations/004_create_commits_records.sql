-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio, token, weight, level) VALUES (74, 86.9, 'legacy', 10.49, 87);
INSERT INTO commits_records (active, ratio, token, weight, level) VALUES (22, 46.32, 'stable', 17.97, 73);
INSERT INTO commits_records (active, ratio, token, weight, level) VALUES (86, 73.27, 'edge', 42.43, 34);
