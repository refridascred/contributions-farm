-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, label, ratio, level) VALUES ('blue', 'latest', 2.09, 38);
INSERT INTO commits_records (owner, label, ratio, level) VALUES ('staging', 'open', 77.82, 32);
INSERT INTO commits_records (owner, label, ratio, level) VALUES ('open', 'eu-west', 98.43, 22);
