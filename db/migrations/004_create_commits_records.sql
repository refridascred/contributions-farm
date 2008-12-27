-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, token, weight) VALUES ('cached', 'eu-west', 28.26);
INSERT INTO commits_records (label, token, weight) VALUES ('strict', 'standard', 78.96);
