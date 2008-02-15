-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, token, weight, score) VALUES (61, 'latest', 76.45, 95.86);
INSERT INTO layout_items (count, token, weight, score) VALUES (10, 'primary', 43.04, 83.18);
INSERT INTO layout_items (count, token, weight, score) VALUES (39, 'cached', 43.02, 85.5);
