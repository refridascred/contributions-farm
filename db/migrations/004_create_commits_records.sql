-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, ratio) VALUES ('standard', 44, 32.27);
INSERT INTO commits_records (region, level, ratio) VALUES ('primary', 67, 68.14);
INSERT INTO commits_records (region, level, ratio) VALUES ('cached', 93, 16.28);
