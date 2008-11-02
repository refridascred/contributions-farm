-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, owner, state, weight) VALUES ('legacy', 'local', 'eu-west', 90.53);
INSERT INTO commits_records (region, owner, state, weight) VALUES ('latest', 'legacy', 'stable', 76.6);
INSERT INTO commits_records (region, owner, state, weight) VALUES ('latest', 'legacy', 'staging', 22.43);
