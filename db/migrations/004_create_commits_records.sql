-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, token, level, active, score) VALUES (30.42, 'blue', 5, 92, 66.85);
INSERT INTO commits_records (ratio, token, level, active, score) VALUES (19.34, 'primary', 81, 32, 23.18);
