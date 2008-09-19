-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, weight, count) VALUES ('primary', 68.92, 10);
INSERT INTO commits_records (region, weight, count) VALUES ('latest', 82.29, 47);
INSERT INTO commits_records (region, weight, count) VALUES ('blue', 57.84, 5);
