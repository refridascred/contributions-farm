-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, label, weight) VALUES ('open', 'stable', 97.35);
INSERT INTO commits_records (owner, label, weight) VALUES ('primary', 'latest', 88.44);
INSERT INTO commits_records (owner, label, weight) VALUES ('stable', 'strict', 23.82);
