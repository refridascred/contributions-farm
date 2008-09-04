-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio) VALUES (68, 75.29);
INSERT INTO commits_records (level, ratio) VALUES (9, 24.38);
INSERT INTO commits_records (level, ratio) VALUES (11, 36.32);
