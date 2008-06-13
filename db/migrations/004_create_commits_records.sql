-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, count, ratio) VALUES ('edge', 41, 49.96);
INSERT INTO commits_records (owner, count, ratio) VALUES ('open', 66, 14.17);
INSERT INTO commits_records (owner, count, ratio) VALUES ('local', 45, 87.56);
