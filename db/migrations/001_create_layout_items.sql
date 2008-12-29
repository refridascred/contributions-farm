-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, score) VALUES (44.49, 'stable', 76.36);
INSERT INTO layout_items (weight, token, score) VALUES (7.82, 'primary', 70.32);
