-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, label, ratio) VALUES (97, 87.9, 'stable', 39.29);
INSERT INTO layout_items (level, weight, label, ratio) VALUES (4, 52.47, 'green', 73.39);
