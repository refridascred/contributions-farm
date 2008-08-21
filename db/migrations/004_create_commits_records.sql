-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, owner, level) VALUES (84.69, 'eu-west', 34);
INSERT INTO commits_records (ratio, owner, level) VALUES (50.76, 'standard', 77);
