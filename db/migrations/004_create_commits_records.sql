-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, token, level, active) VALUES ('edge', 'strict', 43, 30);
INSERT INTO commits_records (owner, token, level, active) VALUES ('cached', 'stable', 47, 59);
INSERT INTO commits_records (owner, token, level, active) VALUES ('stable', 'standard', 96, 35);
