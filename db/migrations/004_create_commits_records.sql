-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, ratio) VALUES (69, 'blue', 70.29);
INSERT INTO commits_records (active, owner, ratio) VALUES (2, 'primary', 56.7);
INSERT INTO commits_records (active, owner, ratio) VALUES (38, 'blue', 73.37);
