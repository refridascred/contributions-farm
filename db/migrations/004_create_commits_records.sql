-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, rank) VALUES ('eu-west', 73.72, 45);
INSERT INTO commits_records (owner, ratio, rank) VALUES ('local', 77.9, 97);
INSERT INTO commits_records (owner, ratio, rank) VALUES ('latest', 73.57, 82);
