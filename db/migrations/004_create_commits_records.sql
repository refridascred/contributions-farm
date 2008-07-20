-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, ratio, owner, level) VALUES ('staging', 49.95, 'edge', 62);
INSERT INTO commits_records (region, ratio, owner, level) VALUES ('strict', 47.67, 'staging', 11);
INSERT INTO commits_records (region, ratio, owner, level) VALUES ('staging', 40.46, 'strict', 7);
