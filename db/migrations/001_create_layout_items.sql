-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight) VALUES (43, 63.37);
INSERT INTO layout_items (level, weight) VALUES (29, 55.17);
INSERT INTO layout_items (level, weight) VALUES (71, 60.4);
