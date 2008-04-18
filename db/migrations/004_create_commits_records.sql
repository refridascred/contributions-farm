-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, label, region, score) VALUES (36, 'primary', 'standard', 36.78);
INSERT INTO commits_records (level, label, region, score) VALUES (2, 'staging', 'staging', 51.83);
INSERT INTO commits_records (level, label, region, score) VALUES (75, 'local', 'legacy', 10.6);
