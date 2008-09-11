-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, label, weight) VALUES (15, 'blue', 97.7);
INSERT INTO layout_items (level, label, weight) VALUES (70, 'blue', 89.27);
INSERT INTO layout_items (level, label, weight) VALUES (46, 'primary', 44.44);
