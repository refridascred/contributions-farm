-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, score, owner, weight, token) VALUES ('legacy', 93.85, 'blue', 45.41, 'edge');
INSERT INTO layout_items (label, score, owner, weight, token) VALUES ('strict', 63.1, 'green', 9.82, 'standard');
INSERT INTO layout_items (label, score, owner, weight, token) VALUES ('eu-west', 51.98, 'latest', 64.43, 'edge');
