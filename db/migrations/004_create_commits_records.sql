-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, active, region, token, rank) VALUES (74, 44, 'latest', 'local', 28);
INSERT INTO commits_records (level, active, region, token, rank) VALUES (64, 65, 'latest', 'local', 73);
INSERT INTO commits_records (level, active, region, token, rank) VALUES (92, 68, 'latest', 'primary', 78);
