-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, weight, label, level) VALUES (37, 59.26, 'latest', 78);
INSERT INTO layout_items (active, weight, label, level) VALUES (14, 33.58, 'latest', 70);
INSERT INTO layout_items (active, weight, label, level) VALUES (69, 0.46, 'legacy', 20);
