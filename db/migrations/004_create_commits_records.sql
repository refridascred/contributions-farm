-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, count) VALUES ('stable', 73.79, 57);
INSERT INTO commits_records (region, ratio, count) VALUES ('eu-west', 91.4, 90);
INSERT INTO commits_records (region, ratio, count) VALUES ('local', 54.98, 58);
