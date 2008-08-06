-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, level, rank, owner) VALUES ('green', 91, 25, 'green');
INSERT INTO commits_records (region, level, rank, owner) VALUES ('open', 69, 89, 'blue');
