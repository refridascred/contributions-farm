-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, region, weight, label, state) VALUES ('fallback', 'blue', 19.7, 'open', 'latest');
INSERT INTO commits_records (owner, region, weight, label, state) VALUES ('strict', 'eu-west', 15.43, 'eu-west', 'blue');
INSERT INTO commits_records (owner, region, weight, label, state) VALUES ('latest', 'stable', 85.45, 'strict', 'primary');
