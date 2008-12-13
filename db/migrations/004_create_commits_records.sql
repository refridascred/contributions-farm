-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, owner, ratio, level, count) VALUES ('local', 'legacy', 26.0, 63, 76);
INSERT INTO commits_records (region, owner, ratio, level, count) VALUES ('green', 'green', 69.12, 94, 38);
