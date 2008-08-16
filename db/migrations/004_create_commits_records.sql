-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count, weight) VALUES ('open', 96, 75.46);
INSERT INTO commits_records (region, count, weight) VALUES ('latest', 19, 71.25);
INSERT INTO commits_records (region, count, weight) VALUES ('eu-west', 45, 73.77);
