-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, label, weight) VALUES (39.42, 'strict', 29.74);
INSERT INTO layout_items (score, label, weight) VALUES (23.14, 'stable', 9.9);
INSERT INTO layout_items (score, label, weight) VALUES (37.37, 'cached', 26.95);
