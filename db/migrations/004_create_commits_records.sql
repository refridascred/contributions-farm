-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, owner, rank, region, active) VALUES ('staging', 'green', 4, 'green', 76);
INSERT INTO commits_records (token, owner, rank, region, active) VALUES ('local', 'strict', 0, 'primary', 13);
INSERT INTO commits_records (token, owner, rank, region, active) VALUES ('green', 'green', 22, 'primary', 56);
