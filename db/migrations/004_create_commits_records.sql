-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio) VALUES (34, 9.53);
INSERT INTO commits_records (level, ratio) VALUES (99, 79.93);
