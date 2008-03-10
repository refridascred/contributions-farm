-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, label) VALUES ('edge', 51.38, 'standard');
INSERT INTO layout_items (token, score, label) VALUES ('green', 82.76, 'eu-west');
INSERT INTO layout_items (token, score, label) VALUES ('legacy', 7.08, 'edge');
