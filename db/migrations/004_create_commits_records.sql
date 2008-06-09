-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, ratio, level) VALUES (30, 'green', 91.2, 84);
INSERT INTO commits_records (active, region, ratio, level) VALUES (28, 'strict', 86.93, 21);
