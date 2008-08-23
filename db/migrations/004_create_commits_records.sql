-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, ratio) VALUES (11, 18.81);
INSERT INTO commits_records (level, ratio) VALUES (2, 75.64);
INSERT INTO commits_records (level, ratio) VALUES (9, 74.47);
