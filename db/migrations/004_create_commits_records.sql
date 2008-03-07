-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, weight, owner, level, rank) VALUES ('local', 32.13, 'local', 0, 24);
INSERT INTO commits_records (label, weight, owner, level, rank) VALUES ('latest', 37.01, 'staging', 3, 28);
