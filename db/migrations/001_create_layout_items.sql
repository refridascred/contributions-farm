-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, score, weight, token, label) VALUES (89, 10.57, 58.23, 'edge', 'staging');
INSERT INTO layout_items (count, score, weight, token, label) VALUES (32, 91.88, 42.39, 'latest', 'cached');
INSERT INTO layout_items (count, score, weight, token, label) VALUES (51, 46.98, 11.29, 'fallback', 'stable');
