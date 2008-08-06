-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, level, ratio, token) VALUES (65.65, 82, 6.95, 'staging');
INSERT INTO commits_records (score, level, ratio, token) VALUES (36.35, 27, 12.06, 'blue');
