-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, owner, weight) VALUES (87.42, 'green', 33.84);
INSERT INTO commits_records (ratio, owner, weight) VALUES (85.14, 'local', 88.84);
