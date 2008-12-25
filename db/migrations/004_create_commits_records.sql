-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, level) VALUES (32.93, 58);
INSERT INTO commits_records (weight, level) VALUES (3.87, 14);
INSERT INTO commits_records (weight, level) VALUES (54.16, 9);
