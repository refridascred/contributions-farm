-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, owner, state) VALUES (14, 88.23, 'edge', 'edge');
INSERT INTO commits_records (active, weight, owner, state) VALUES (47, 10.57, 'eu-west', 'eu-west');
INSERT INTO commits_records (active, weight, owner, state) VALUES (39, 87.55, 'stable', 'green');
