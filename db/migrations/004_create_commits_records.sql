-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, owner, weight, state) VALUES ('stable', 'local', 47.54, 'stable');
INSERT INTO commits_records (region, owner, weight, state) VALUES ('cached', 'local', 1.66, 'latest');
INSERT INTO commits_records (region, owner, weight, state) VALUES ('legacy', 'stable', 82.69, 'primary');
