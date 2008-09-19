-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, label, weight, owner) VALUES ('cached', 'latest', 58.2, 'blue');
INSERT INTO commits_records (region, label, weight, owner) VALUES ('legacy', 'latest', 97.98, 'blue');
INSERT INTO commits_records (region, label, weight, owner) VALUES ('stable', 'fallback', 91.11, 'green');
