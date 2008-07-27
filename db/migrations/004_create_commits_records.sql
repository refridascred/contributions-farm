-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank) VALUES (34.08, 87);
INSERT INTO commits_records (ratio, rank) VALUES (87.02, 41);
INSERT INTO commits_records (ratio, rank) VALUES (1.97, 23);
