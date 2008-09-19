-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, owner, weight) VALUES ('primary', 'local', 72.22);
INSERT INTO commits_records (state, owner, weight) VALUES ('staging', 'local', 92.3);
INSERT INTO commits_records (state, owner, weight) VALUES ('local', 'legacy', 95.57);
