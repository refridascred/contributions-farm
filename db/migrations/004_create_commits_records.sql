-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, active, token, level) VALUES ('eu-west', 11, 'legacy', 46);
INSERT INTO commits_records (owner, active, token, level) VALUES ('blue', 82, 'stable', 7);
INSERT INTO commits_records (owner, active, token, level) VALUES ('latest', 2, 'strict', 59);
