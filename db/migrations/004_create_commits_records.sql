-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, label, active, weight) VALUES ('green', 'stable', 53, 26.59);
INSERT INTO commits_records (owner, label, active, weight) VALUES ('eu-west', 'blue', 7, 6.17);
INSERT INTO commits_records (owner, label, active, weight) VALUES ('open', 'open', 33, 54.11);
