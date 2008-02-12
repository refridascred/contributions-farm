-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, active, weight) VALUES ('legacy', 99, 74.58);
INSERT INTO layout_items (region, active, weight) VALUES ('edge', 70, 61.37);
INSERT INTO layout_items (region, active, weight) VALUES ('eu-west', 14, 97.67);
