-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, region, score, label) VALUES ('open', 'blue', 53.64, 'edge');
INSERT INTO layout_items (token, region, score, label) VALUES ('latest', 'edge', 94.66, 'eu-west');
INSERT INTO layout_items (token, region, score, label) VALUES ('stable', 'green', 76.49, 'latest');
