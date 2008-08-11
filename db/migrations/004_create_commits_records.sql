-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, token, active, level) VALUES (62.03, 'stable', 'eu-west', 33, 68);
INSERT INTO commits_records (ratio, owner, token, active, level) VALUES (71.71, 'edge', 'staging', 28, 65);
INSERT INTO commits_records (ratio, owner, token, active, level) VALUES (14.38, 'blue', 'stable', 16, 57);
