-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, token, region, ratio) VALUES ('eu-west', 97.52, 'latest', 'strict', 11.33);
INSERT INTO commits_records (state, weight, token, region, ratio) VALUES ('standard', 50.44, 'green', 'cached', 73.46);
INSERT INTO commits_records (state, weight, token, region, ratio) VALUES ('standard', 72.59, 'blue', 'stable', 3.33);
