-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, token, level) VALUES ('primary', 19.51, 'blue', 20);
INSERT INTO commits_records (state, weight, token, level) VALUES ('stable', 94.0, 'eu-west', 15);
INSERT INTO commits_records (state, weight, token, level) VALUES ('stable', 7.81, 'green', 54);
