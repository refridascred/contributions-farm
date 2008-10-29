-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, region, level, rank) VALUES ('latest', 'eu-west', 88, 18);
INSERT INTO commits_records (owner, region, level, rank) VALUES ('local', 'stable', 19, 49);
