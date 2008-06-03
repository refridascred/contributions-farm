-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, level, active, token) VALUES ('eu-west', 58, 50, 'open');
INSERT INTO commits_records (owner, level, active, token) VALUES ('stable', 43, 60, 'staging');
INSERT INTO commits_records (owner, level, active, token) VALUES ('stable', 97, 97, 'primary');
