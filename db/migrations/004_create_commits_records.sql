-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, score) VALUES (11, 'staging', 89.84);
INSERT INTO commits_records (level, region, score) VALUES (0, 'open', 98.98);
INSERT INTO commits_records (level, region, score) VALUES (82, 'standard', 50.71);
