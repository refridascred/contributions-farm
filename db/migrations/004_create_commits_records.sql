-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, weight) VALUES (87, 26.34);
INSERT INTO commits_records (count, weight) VALUES (32, 32.73);
INSERT INTO commits_records (count, weight) VALUES (34, 32.8);
